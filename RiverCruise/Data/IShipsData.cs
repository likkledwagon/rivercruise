using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.ProxyModel.Advalvas;
using Data.ProxyModel.Company;
using Data.ProxyModel.Ship;
using DataModels;
using System.Data.Entity;

namespace Data
{
    public interface IShipsData : IDisposable
    {
        DbSet<Ship> Ships { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<Report> Reports { get; set; }
        IEnumerable<object> GetUsers { get; }
        DbSet<Advalvas> Advalvases { get; set; }

        new void Dispose();
        int SaveChanges();
        void DeleteShip(int id);
        void EditShipData(EditShipProxyModel dataShip);
        void EditCompanyData(EditCompanyProxyModel proxyModel);
        void AddCompany(NewCompanyProxyModel proxyModel);
        void DeleteCompany(DeleteCompanyProxyModel deleteCompanyProxyModel);
        void ChangeCompay(ChangeCompanyProxyModel toChangeCompanyProxyModel);
        void AddAdvalvas(AddAdvalvasModel model);
    }
}
