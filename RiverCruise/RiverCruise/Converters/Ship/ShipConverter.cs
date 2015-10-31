using System;
using System.Collections.ObjectModel;
using System.Linq;
using Data;
using Data.ProxyModel.Ship;
using DataModels;
using RiverCruise.Models.ShipManagement;

namespace RiverCruise.Converters.Ship
{
    public static class ShipConverter
    {
        public static Ship2Company ToNewShipDataModel(this NewShipViewModel newShipViewModel)
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
                        From = newShipViewModel.Since,
                        Until = new DateTime(9999, 12, 31),
                        Ship = new DataModels.Ship
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
                            Remark = newShipViewModel.Remark,
                            MmsiNummer = newShipViewModel.MmsiNummer,
                            AantalPassagiers = newShipViewModel.AantalPassagiers
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

        public static EditShipProxyModel ToEditShipDataModel(this EditShipViewModel editShipViewModel)
        {
            return new EditShipProxyModel()
            {
                Id = editShipViewModel.Id,
                Name = editShipViewModel.Name,
                Eni = editShipViewModel.Eni,
                Flag = editShipViewModel.Flag,
                Region = editShipViewModel.Region,
                NauticalCrew = editShipViewModel.NauticalCrew,
                HotelStaff = editShipViewModel.HotselStaff,
                Since = editShipViewModel.Since,
                Remark = editShipViewModel.Remark,
                MmsiNummer = editShipViewModel.MmsiNummer,
                AantalPassagiers = editShipViewModel.AantalPassagiers
            };
        }
    }
}