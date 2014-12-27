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
                company.Ship2Company = new Collection<Ship2Company>() { new Ship2Company() { Company = company, From = DateTime.Now, Until = new DateTime(9999, 12, 31), Ship = new Ship() { Eni = "4801170", Flag = "GFR", Crew = new Collection<Crew>() {new Crew(){HotelStaff = 44, NauticalCrew = 6, From = new DateTime(1900, 01, 01), Until = new DateTime(9999, 12, 31)}}, Name = "A'ROSA BELLA", Region = "Danube" } }};
                context.Companies.Add(company);
                context.SaveChanges();
        }

    }
}