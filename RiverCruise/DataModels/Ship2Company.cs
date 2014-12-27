using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Ship2Company
    {
        public int Id { get; set; }
        public virtual Ship Ship { get; set; }
        public virtual Company Company { get; set; }
        public DateTime From { get; set; }
        public DateTime Until { get; set; }
    }
}
