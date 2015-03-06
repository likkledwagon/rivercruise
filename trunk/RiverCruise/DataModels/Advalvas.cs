using System.ComponentModel.DataAnnotations;

namespace DataModels
{
    public class Advalvas
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; } 
    }
}