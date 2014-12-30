using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Mvc;
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
            SaveChanges();
        }

        public void AddCompany(NewCompanyProxyModel proxyModel)
        {
            Companies.Add(new Company()
            {
                Name = proxyModel.Name
            });
            SaveChanges();
        }

        public void DeleteCompany(DeleteCompanyProxyModel deleteCompanyProxyModel)
        {
            var company = Companies.Find(deleteCompanyProxyModel.Id);

            company.Ship2Company.Select(x => x.Ship.Id).ToList().ForEach(DeleteShip);
            Companies.Remove(company);

            SaveChanges();
        }

        public new void Dispose()
        {
            base.Dispose();
        }
    }
}
