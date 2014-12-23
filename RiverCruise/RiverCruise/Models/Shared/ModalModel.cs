using System.Collections.Generic;
using System.Web.Mvc;

namespace RiverCruise.Models.Shared
{
    public class ModalModel
    {
        public string Action { get; set; }
        public string Controller { get; set; }
        public IDictionary<string, object> Arguments { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}