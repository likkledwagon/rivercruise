using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;

namespace RiverCruise.Models.Ship
{
    public class ShipDetailModel
    {
        public bool DeleteFailed { get; set; }
        private readonly int _nauticalCrew;
        private readonly int _hotelStaff;
        private const string Unknown = "?";

        public ShipDetailModel(DataModels.Ship ship, bool deleteFailed = false)
        {
            DeleteFailed = deleteFailed;
            _nauticalCrew = ship.Crew.First(x => x.From < DateTime.Now && x.Until >= DateTime.Now).NauticalCrew.GetValueOrDefault();
            _hotelStaff = ship.Crew.First(x => x.From < DateTime.Now && x.Until >= DateTime.Now).HotelStaff.GetValueOrDefault();
            CompanyName = ship.Ship2Company.First(y => (y.From < DateTime.Now) && (DateTime.Now <= y.Until)).Company.Name;
            CompanyId = ship.Ship2Company.First(y => (y.From < DateTime.Now) && (DateTime.Now <= y.Until)).Company.Id;
            Eni = ship.Eni;
            Flag = ship.Flag;
            Region = ship.Region;
            Name = ship.Name;
            ShipId = ship.Id;
            Remark = ship.Remark;
            MmsiNummer = ship.MmsiNummer;
            AantalPassagiers = ship.AantalPassagiers;
        }

        [Display(Name="Aantal passagiers")]
        public int AantalPassagiers { get; set; }

        [Display(Name="MMSI number")]
        public string MmsiNummer { get; set; }

        public string Remark { get; set; }

        public int ShipId { get; set; }

        public string Name { get; set; }

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