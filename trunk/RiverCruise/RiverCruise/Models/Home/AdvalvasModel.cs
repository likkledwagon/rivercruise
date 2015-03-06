using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RiverCruise.Models.Home
{
    public class AdvalvasModel
    {
        public List<Advalvas> Advalvas { get; set; }

        public AdvalvasModel()
        {
        }

        public AdvalvasModel(DbSet<DataModels.Advalvas> queryResult)
        {
            Advalvas = queryResult.Select(x => new Advalvas(){Title = x.Title}).ToList();
        }
    }
}