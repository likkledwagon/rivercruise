using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DataModels;

namespace RiverCruise.Models.Ship
{
    public class ShipHistoryModel:BasePagingModel
    {
        public ShipHistoryModel(IEnumerable<Crew> crew, int page, int totalItems)
        {
            Crew = crew.OrderByDescending(y => y.From).Skip((page-1)*ItemsPerPage).Take(ItemsPerPage).Select(x => new ShipHistoryCrewModel(x));
            Action = "ShipHistory";
            Initialize(page, totalItems, "Home");
        }

        public IEnumerable<ShipHistoryCrewModel> Crew { get; set; }
    }

    public class ShipHistoryCrewModel
    {
        private DateTime _from;
        private DateTime _until;

        public ShipHistoryCrewModel(Crew crew)
        {
            NauticalCrew = crew.NauticalCrew.GetValueOrDefault(0);
            HotelStaff = crew.HotelStaff.GetValueOrDefault(0);
            _from = crew.From;
            _until = crew.Until;
        }

        public string From
        {
            get { return _from.ToString("mmmm dd yyyy"); }
        }

        public string Until
        {
            get { return _until.ToString("mmmm dd yyyy"); }
        }

        [Display(Name="Hotel staff")]
        public int HotelStaff { get; set; }

        [Display(Name="Nautical crew")]
        public int NauticalCrew { get; set; }

        [Display(Name="Total crew")]
        public int TotalCrew
        {
            get { return NauticalCrew + HotelStaff; }
        }
    }
}