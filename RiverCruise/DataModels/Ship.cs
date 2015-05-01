using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DataModels
{
    public class Ship
    {
        public int Id { get; set; }

        public string Name { get; set;}

        public virtual Collection<Ship2Company> Ship2Company { get; set; }

        public virtual string Region { get; set; }
        public string Eni { get; set; }

        [StringLength(3)]
        public string Flag { get; set; }

        public string Remark { get; set; }

        public virtual Collection<Crew> Crew { get; set; }

        public virtual Collection<FileAttachement> Attachements { get; set; }

        public virtual Collection<Report> Reports { get; set; }
    }
}
