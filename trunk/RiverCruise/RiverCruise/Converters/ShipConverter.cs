using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using DataModels;
using RiverCruise.Models.ShipManagement;

namespace RiverCruise.Converters
{
    public static class ShipConverter
    {
        //public static Ship ToShipDataModel(this NewShipViewModel newShipViewModel)
        //{
        //    Company company;
        //    using (IShipsData shipData = new RiverCruiseDB())
        //    {
        //        company = shipData.Companies.SingleOrDefault(x => x.Id == newShipViewModel.Comany.Id);
        //    }

        //    if (company == null)
        //    {
        //        return null;
        //    }

        //    return new Ship()
        //    {
        //        Ship2Company = new List<Ship2Company>(){new Ship2Company(){Company = company, From = DateTime.Now, 
        //        Eni = newShipViewModel.Eni,
        //        Flag = newShipViewModel.Flag,
        //        HotelStaff = newShipViewModel.HotselStaff,
        //        Name = newShipViewModel.Name,
        //        NauticalCrew = newShipViewModel.NauticalCrew,
        //        Region = newShipViewModel.Region
        //    };
        //}
    }
}