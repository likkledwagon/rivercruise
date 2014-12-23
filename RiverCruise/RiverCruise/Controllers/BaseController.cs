using System.Web.Mvc;
using Data;

namespace RiverCruise.Controllers
{
    [Authorize]
    public abstract class BaseController : Controller
    {
        protected readonly IShipsData _db = new RiverCruiseDB();

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}