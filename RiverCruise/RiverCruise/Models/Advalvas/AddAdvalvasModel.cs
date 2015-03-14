using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace RiverCruise.Models.Advalvas
{
    public class AddAdvalvasModel
    {
        [Required]
        [AllowHtml]
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