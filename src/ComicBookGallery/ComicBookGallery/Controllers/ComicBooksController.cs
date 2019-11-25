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
            ViewBag.SeriesTitle = "The Amazing SpiderMan";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the death of Dr. Octopus!</p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos",
            };

            return View();
        }
    }
}