using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DVDController : Controller
    {
        // GET: DVD
    //    public ActionResult Index()
    //    {
    //        return View();
    //    }

        public string Index()
        {
            return "Hellow from Store.Index";
        }

        public string Browse( string genre)
        {
            string message = HttpUtility.HtmlEncode("Dvd.Browse, Genere = " + genre);
            return message;
        }

        public string Details()
        {
            return "Hello from Store.Details";
        }
    }
}