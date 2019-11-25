using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET: ComicBooks
        public ActionResult Detail()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }

            return Content("<h1>Hello from the Details Controller</h1>");
        }
    }
}