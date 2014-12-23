using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Ship
    {
        public int Id { get; set; }

        public string Name { get; set;}

        public virtual Company Company { get; set; }

        public virtual string Region { get; set; }
        public virtual List<Report> Reports { get; set; }
        public string Eni { get; set; }

        [StringLength(3)]
        public string Flag { get; set; }

        public int? NauticalCrew { get; set; }
        public int? HotelStaff { get; set; }
    }
}
