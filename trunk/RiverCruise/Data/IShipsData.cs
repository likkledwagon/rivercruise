using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels;
using System.Data.Entity;

namespace Data
{
    public interface IShipsData
    {
        DbSet<Ship> Ships { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<Report> Reports { get; set; }

        void Dispose();
    }
}
