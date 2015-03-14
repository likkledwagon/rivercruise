using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DataModels;
using Newtonsoft.Json;

namespace RiverCruise.Models.Ship
{
    public class ShipAttachmentsModel : BasePagingModel
    {
        public ShipAttachmentsModel(IEnumerable<FileAttachement> attachements, int page, int totalItems, int shipId)
        {
            Attachements = attachements.OrderByDescending(o => o.InsetTime)
                .Skip((page - 1) * ItemsPerPage).Take(ItemsPerPage)
                .Select(x => new ShipAttachement()
                {
                    Date = x.InsetTime,
                    Name = x.Name,
                    Id = x.Id
                });
            Initialize(page, totalItems, "Home");
            Id = shipId;
        }

        public IEnumerable<ShipAttachement> Attachements { get; set; }
        public int Id { get; set; }
    }
}