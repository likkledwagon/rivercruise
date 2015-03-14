using System.ComponentModel.DataAnnotations;

namespace RiverCruise.Models.Advalvas
{
    public class AddAdvalvasModel
    {
        [Required]
        [DataType(DataType.MultilineText)]
        public string Title { get; set; }

        public Data.ProxyModel.Advalvas.AddAdvalvasModel ToDataModel()
        {
            return new Data.ProxyModel.Advalvas.AddAdvalvasModel()
            {
                Title = this.Title
            };
        }
    }
}