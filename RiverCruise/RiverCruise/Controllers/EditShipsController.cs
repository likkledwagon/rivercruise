using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using Data;

namespace RiverCruise.Controllers
{
    public class EditShipsController : Controller
    {
        private IShipsData _db = new RiverCruiseDB();

        /*
        public ActionResult Index()
        {
            return View(_db.Ships);
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
        */
    }
}
