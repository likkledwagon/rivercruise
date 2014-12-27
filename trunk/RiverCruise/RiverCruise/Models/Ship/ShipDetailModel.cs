using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using RiverCruise.Models.Report;

namespace RiverCruise.Models.Ship
{
    public class ShipDetailModel
    {
        private readonly int _nauticalCrew;
        private readonly int _hotelStaff;
        private const string Unknown = "?";

        public ShipDetailModel(DataModels.Ship ship)
        {
            _nauticalCrew = ship.NauticalCrew.GetValueOrDefault();
            _hotelStaff = ship.HotelStaff.GetValueOrDefault();
            CompanyName = ship.Ship2Company.First(y => (y.From < DateTime.Now) && (DateTime.Now <= y.Until)).Company.Name;
            CompanyId = ship.Ship2Company.First(y => (y.From < DateTime.Now) && (DateTime.Now <= y.Until)).Company.Id;
            Eni = ship.Eni;
            Flag = ship.Flag;
            Region = ship.Region;
            Name = ship.Name;

            Reports = ship.Reports.Select(x => new ShipDetailReportViewModel(x)).ToList();
        }

        public string Name { get; set; }

        public List<ShipDetailReportViewModel> Reports { get; set; }

        [Display(Name="Company")]
        public string CompanyName { get; set; }
        public string Eni { get; set; }
        public string Flag { get; set; }
        public string Region { get; set; }

        [Display(Name = "Nautical crew")]
        public string NauticalCrew
        {
            get
            {
                return _nauticalCrew > 0 ? _nauticalCrew.ToString(CultureInfo.InvariantCulture) : Unknown;
            }
        }

        [Display(Name = "Hotel staff")]
        public string HotelStaff
        {
            get
            {
                return _hotelStaff > 0 ? _hotelStaff.ToString(CultureInfo.InvariantCulture) : Unknown;
            }
        }

        [Display(Name="Total crew")]
        public string TotalCrew
        {
            get
            {
                int crew = (_nauticalCrew + _hotelStaff);
                return crew > 0 ? crew.ToString(CultureInfo.InvariantCulture) : Unknown;
            }
        }

        public int CompanyId { get; set; }
    }
}