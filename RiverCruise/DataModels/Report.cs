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
        
        [Display(Description = "Date of visit", Name = "Date of visit", ShortName = "Date of visit")]
        public DateTime Date { get; set; }
        public Ship Ship { get; set; }
        
        public string Port { get; set; }
        public byte[] File { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime InsertTime { get; set; }
    }
}
