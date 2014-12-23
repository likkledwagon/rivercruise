using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Ship> Ships { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
