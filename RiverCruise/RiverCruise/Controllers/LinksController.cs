﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RiverCruise.Controllers
{
    public class LinksController : BaseController
    {
        // GET: Links
        public ActionResult Index()
        {
            return View();
        }
    }
}