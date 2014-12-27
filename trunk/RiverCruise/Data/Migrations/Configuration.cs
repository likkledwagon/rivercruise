using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Security.AccessControl;
using Data.DataGenerators;
using DataModels;

namespace Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.RiverCruiseDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Data.RiverCruiseDB context)
        {
            if(!context.Ships.Any())
            {
                ShipsAndCompaniesDataGenerator.FillShipsAndCompanies(context);
            }
        }
    }
}
