using librarymanagement1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace librarymanagement1.Controllers
{
    public class pendingbookController : Controller
    {
        // GET: pendingbook
        public ActionResult bookpending()
        {
           
            return View();
        }
    }
}