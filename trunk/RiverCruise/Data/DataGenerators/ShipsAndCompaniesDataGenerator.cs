using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using System.Diagnostics;
using DataModels;

namespace Data.DataGenerators
{
    public class ShipsAndCompaniesDataGenerator
    {
        public static void FillShipsAndCompanies(RiverCruiseDB context)
        {
            var vessels = new List<Ship>();
            
                Company company;
                company = new Company() {Name = "A\'ROSA"};
                company.Ship2Company = new Collection<Ship2Company>() { new Ship2Company() { Company = company, From = DateTime.Now, Until = new DateTime(9999, 12, 31), Ship = new Ship() { Eni = "4801170", Flag = "GFR", HotelStaff = 44, Name = "A'ROSA BELLA", NauticalCrew = 6, Region = "Danube" } }};
                context.Companies.Add(company);
                context.SaveChanges();
        }

    }
}