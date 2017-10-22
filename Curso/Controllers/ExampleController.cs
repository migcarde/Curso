*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curso.Controllers
{
    public class ExampleController : Controller
    {
        private ConferenceContext db = new ConferenceContext();


        // GET: Example
        public ActionResult Index()
        {
            return View();
        }
    }
}