using System;
using System.Collections.ObjectModel;
using System.Linq;
using Data;
using DataModels;
using RiverCruise.Models.ShipManagement;

namespace RiverCruise.Converters
{
    public static class ShipConverter
    {
        public static Ship2Company ToShipDataModel(this NewShipViewModel newShipViewModel)
        {
            try
            {
                using (IShipsData shipData = new RiverCruiseDB())
                {
                    var company = shipData.Companies.SingleOrDefault(x => x.Id == newShipViewModel.Comany.Id);
                    if (company == null)
                    {
                        return null;
                    }

                    var ship2Company = new Ship2Company
                    {
                        From = DateTime.Now,
                        Until = new DateTime(9999, 12, 31),
                        Ship = new Ship
                        {
                            Crew =
                                new Collection<Crew>
                                {
                                    new Crew
                                    {
                                        From = DateTime.Now,
                                        Until = new DateTime(9999, 12, 31),
                                        HotelStaff = newShipViewModel.HotselStaff,
                                        NauticalCrew = newShipViewModel.NauticalCrew
                                    }
                                },
                            Eni = newShipViewModel.Eni,
                            Flag = newShipViewModel.Flag,
                            Name = newShipViewModel.Name,
                            Region = newShipViewModel.Region,
                        }
                    };

                    company.Ship2Company.Add(ship2Company);

                    shipData.SaveChanges();

                    return ship2Company;
                }
            }
            catch (Exception)
            {
                return null;
            }           
        }
    }
}