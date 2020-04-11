using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppAndAPI.Models;

namespace WebAppAndAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //two post routes to return all hotels
        [HttpPost]
        public IActionResult Index(int hotel)
        {
            //return RedirectToAction("Results", new { hotels });
            return null;
        }
    
        [HttpPost]
        public IActionResult Results()
        {
         //   List<Hotels> hotels = //query for all hotels here

           // return View(hotels);
            return null;
        }
    }
}