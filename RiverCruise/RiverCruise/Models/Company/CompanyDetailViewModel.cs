using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using DataModels;
using RiverCruise.Models.Ship;

namespace RiverCruise.Models.Company
{
    public class CompanyDetailViewModel
    {
        public const string Unknown = "?";

        public CompanyDetailViewModel(DataModels.Company company)
        {
            Name = company.Name;
            Ships = company.Ships.Select(x => new CompanyshipsModel(x));
            NauticalCrew = company.Ships.Sum(x => x.NauticalCrew != null ? x.NauticalCrew.Value : 0);
            HotelStaff = company.Ships.Sum(x => x.HotelStaff != null ? x.HotelStaff.Value : 0);
            Reports = company.Reports.Count;
            ShipsVisited = company.Ships.Count(x => x.Reports.Any());
            Id = company.Id;
        }

        public string Name { get; set; }
        public IEnumerable<CompanyshipsModel> Ships { get; set; }
        public int NauticalCrew { get; set; }
        public int HotelStaff { get; set; }
        public int Reports { get; set; }
        public int ShipsVisited { get; set; }
        public int Id { get; set; }

        public string PercentageShipsVisited
        {
            get
            {
                if (ShipsVisited == 0)
                {
                    return "0";
                }
                return (Math.Round((double) Ships.Count()/ShipsVisited)*100).ToString(CultureInfo.InvariantCulture);
            }
        }

        [Display(Name = "Total crew")]
        public string TotalCrew
        {
            get
            {
                int crew = (NauticalCrew + HotelStaff);
                return crew > 0 ? crew.ToString(CultureInfo.InvariantCulture) : Unknown;
            }
        }

        [Display(Name = "Nautical Crew")]
        public string NauticalCrewString
        {
            get
            {
                return this.NauticalCrew > 0 ? this.NauticalCrew.ToString(CultureInfo.InvariantCulture) : Unknown;
            }
        }

        [Display(Name="Hotel staff")]
        public string HotelStaffString
        {
            get
            {
                return this.HotelStaff > 0 ? this.HotelStaff.ToString(CultureInfo.InvariantCulture) : Unknown;
            }
        }

        [Display(Name="Reports / Ship")]
        public string ReportsPerShip
        {
            get
            {
                if (Ships.Any())
                {
                    return Math.Round((double) Reports/Ships.Count()).ToString(CultureInfo.InvariantCulture);
                }

                return "0";
            }
        }
    }

    public class CompanyshipsModel : ShipViewModel
    {
        public CompanyshipsModel(DataModels.Ship ship) : base(ship)
        {
        }
    }
}