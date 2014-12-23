using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Report
    {
        public int Id { get; set; }

        [Display(Description = "Ref", Name = "Ref", ShortName = "Ref")]
        public string Ref { get; set; }

        [Display(Description = "Date of visit", Name = "Date of visit", ShortName = "Date of visit")]
        public DateTime Date { get; set; }
        public Ship Ship { get; set; }
        public string Remarks { get; set; }

        public string DateString { get { return string.Format("{0:MMMM d, yyyy}", Date); } }

        [Range(0, 3)]
        public string Flag { get; set; }

        public string Eni { get; set; }

        public virtual Company Company { get; set; }

        public virtual Agent Agent { get; set; }

        public virtual Contract Contract { get; set; }

        public string Port { get; set; }

        public string CrewNationalities { get; set; }
    }

    public class Agent
    {
        [Key]
        public int Id { get; set; }

        public string Nautic { get; set; }
        public string Horeca { get; set; }
    }

    public class Contract
    {
        [Key]
        public int Id { get; set; }

        public string Nautic { get; set; }
        public string Crew { get; set; }
    }
}
