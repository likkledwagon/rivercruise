using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Company
    {
        public Company()
        {
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Website { get; set; }

        public virtual Collection<Ship2Company> Ship2Company { get; set; }
        public virtual Collection<Report> Reports { get; set; }
    }
}
