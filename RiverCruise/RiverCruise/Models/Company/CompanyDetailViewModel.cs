using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RiverCruise.Models.Company
{
    public class CompanyDetailViewModel
    {
        public const string Unknown = "?";

        public CompanyDetailViewModel(DataModels.Company company)
        {
            Name = company.Name;
            Ships = company.Ship2Company.Where(y => (y.From < DateTime.Now) && (DateTime.Now <= y.Until)).OrderBy(o => o.Ship.Name).Select(x => new CompanyshipsModel(x));
            NauticalCrew = company.Ship2Company.Where(y => (y.From < DateTime.Now) && (DateTime.Now <= y.Until))
                .SelectMany(z => z.Ship.Crew).Where(c => c.From < DateTime.Now && c.Until >= DateTime.Now)
                .Sum(x => x.NauticalCrew != null ? x.NauticalCrew.Value : 0);
            HotelStaff = company.Ship2Company.Where(y => (y.From < DateTime.Now) && (DateTime.Now <= y.Until))
                .SelectMany(z => z.Ship.Crew).Where(c => c.From < DateTime.Now && c.Until >= DateTime.Now)
                .Sum(x => x.HotelStaff != null ? x.HotelStaff.Value : 0);
            Reports = company.Ship2Company.Where(y => (y.From < DateTime.Now) && (DateTime.Now <= y.Until)).SelectMany(q => q.Ship.Reports).Count();
            ShipsVisited = company.Ship2Company.Where(y => (y.From < DateTime.Now) && (DateTime.Now <= y.Until)).Count(x => x.Ship.Reports.Any());
            Id = company.Id;
            Website = company.Website;
            CrewingAgent = company.CrewingAgent;
            CrewingagentWebsite = company.CrewingAgentWebsite;
        }

        public string CrewingagentWebsite { get; set; }
        
        [Display(Name="Crewing agent")]
        public string CrewingAgent { get; set; }
        
        public string Website { get; set; }

        public string Name { get; set; }

        public IEnumerable<CompanyshipsModel> Ships { get; set; }
        
        [Display(Name = "Nautical crew")]
        public int NauticalCrew { get; set; }
        
        [Display(Name = "Hotel staff")]
        public int HotelStaff { get; set; }
        
        public int Reports { get; set; }
        
        [Display(Name = "Ships visited")]
        public int ShipsVisited { get; set; }
        
        public int Id { get; set; }

        [Display(Name = "% of ships visited")]
        public string PercentageShipsVisited
        {
            get
            {
                if (ShipsVisited == 0)
                {
                    return "0";
                }
                return (Math.Round(((double)ShipsVisited / Ships.Count()) * 100)).ToString(CultureInfo.InvariantCulture);
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
                    return Math.Round((double) Reports/Ships.Count(), 2).ToString(CultureInfo.InvariantCulture);
                }

                return "0";
            }
        }
    }
}