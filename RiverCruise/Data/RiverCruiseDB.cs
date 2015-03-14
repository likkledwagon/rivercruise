using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Mvc;
using Data.ProxyModel.Advalvas;
using Data.ProxyModel.Company;
using Data.ProxyModel.Ship;
using DataModels;

namespace Data
{
    public class RiverCruiseDB : DbContext, IShipsData
    {
        public RiverCruiseDB()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<Ship> Ships {get; set;}

        public DbSet<Company> Companies { get; set; }

        public DbSet<Report> Reports { get; set; }

        public DbSet<Crew> Crews { get; set; }

        public DbSet<Ship2Company> Ship2Companies { get; set; }

        public DbSet<Advalvas> Advalvases { get; set; }

        public DbSet<FileAttachement> Attachements { get; set; }

        public IEnumerable<dynamic> GetUsers
        {
            get
            {
                using (var db = WebMatrix.Data.Database.Open("DefaultConnection"))
                {
                    return db.Query("SELECT * FROM UserProfile");
                }
            }
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                var newException = new FormattedDbEntityValidationException(e);
                throw newException;
            }
        }

        public void DeleteShip(int id)
        {
            var ship = Ships.First(x => x.Id == id);
            Ship2Companies.RemoveRange(Ship2Companies.Where(x => x.Ship.Id.Equals(id)));
            Crews.RemoveRange(Crews.Where(x => x.Ship.Id.Equals(id)));
            Ships.Remove(ship);
            SaveChanges();
        }

        public void EditShipData(EditShipProxyModel dataShip)
        {
            var ship = Ships.Find(dataShip.Id);
            ship.Name = dataShip.Name;
            ship.Eni = dataShip.Eni;
            ship.Flag = dataShip.Flag;
            ship.Region = dataShip.Region;
            var crew = ship.Crew.Single(x => x.From < DateTime.Now && x.Until >= DateTime.Now);
            crew.HotelStaff = dataShip.HotelStaff;
            crew.NauticalCrew = dataShip.NauticalCrew;

            var ship2Company = ship.Ship2Company.Single(x => x.From < DateTime.Now && x.Until >= DateTime.Now);
            ship2Company.From = dataShip.Since;

            SaveChanges();
        }

        public void EditCompanyData(EditCompanyProxyModel proxyModel)
        {
            var company = Companies.Find(proxyModel.Id);
            company.Name = proxyModel.Name;
            company.Website = proxyModel.Website;
            SaveChanges();
        }

        public void AddCompany(NewCompanyProxyModel proxyModel)
        {
            Companies.Add(new Company()
            {
                Name = proxyModel.Name,
                Website = proxyModel.Website
            });
            SaveChanges();
        }

        public void AddAdvalvas(AddAdvalvasModel model)
        {
            Advalvases.Add(new Advalvas()
            {
                Title = model.Title
            });
            SaveChanges();
        }

        public void RemoveAdvalvas(int id)
        {
            var advalvas = Advalvases.Find(id);
            Advalvases.Remove(advalvas);

            SaveChanges();
        }

        public void AddFileToShip(AddFileToShipProxyModel addFileToShipProxyModel)
        {
            var ship = Ships.Find(addFileToShipProxyModel.ShipId);
            ship.Attachements.Add(new FileAttachement()
            {
                FileBytes = addFileToShipProxyModel.Bytes,
                InsetTime = DateTime.Now,
                Name = addFileToShipProxyModel.FileName,
                Type = addFileToShipProxyModel.Type
            });

            SaveChanges();
        }

        public int DeleteFile(int id)
        {
            var file = Attachements.Find(id);

            var shipId = file.Ship.Id;
            Attachements.Remove(file);

            SaveChanges();
            return shipId;
        }

        public void DeleteCompany(DeleteCompanyProxyModel deleteCompanyProxyModel)
        {
            var company = Companies.Find(deleteCompanyProxyModel.Id);

            if (company.Ship2Company.Any(x => x.Until == new DateTime(9999, 12, 31)))
            {
                throw new Exception("Cannot delete a company that currently has ships.");
            }

            Ship2Companies.RemoveRange(company.Ship2Company);
            company.Ship2Company.Select(x => x.Ship.Id).ToList().ForEach(DeleteShip);
            Companies.Remove(company);

            SaveChanges();
        }

        public void ChangeCompay(ChangeCompanyProxyModel toChangeCompanyProxyModel)
        {
            var company = Companies.Where(x => x.Name.Equals(toChangeCompanyProxyModel.NewCompanyName));

            if (company.Count() != 1)
            {
                throw new Exception("No company found by that name");
            }

            var ship = Ships.Find(toChangeCompanyProxyModel.ShipId);
            if (ship == null)
            {
                throw new Exception("Something went wrong please try again");
            }

            var currentShip2CompaniesToClose = ship.Ship2Company.Where(x => x.Until >= toChangeCompanyProxyModel.Since);
            currentShip2CompaniesToClose.ToList().ForEach(x => CloseCompanyToShip(x, toChangeCompanyProxyModel.Since));
            Ship2Companies.RemoveRange(currentShip2CompaniesToClose.Where(x => x.From == new DateTime(9999, 12, 31)));

            ship.Ship2Company.Add(new Ship2Company()
            {
                Company = company.First(),
                From = toChangeCompanyProxyModel.Since,
                Until = new DateTime(9999, 12, 31),
            });

            SaveChanges();
        }

        private void CloseCompanyToShip(Ship2Company ship2Company, DateTime since)
        {
            if (ship2Company.From > since.AddDays(-1))
            {
                ship2Company.From = new DateTime(9999, 12, 31);
                ship2Company.Until = new DateTime(9999, 12, 31);
            }
            else
            {
                ship2Company.Until = since.AddDays(-1) < new DateTime(1900, 01, 01) ? new DateTime(1900, 01, 01) : since.AddDays(-1);
            }
        }

        public new void Dispose()
        {
            base.Dispose();
        }
    }
}
