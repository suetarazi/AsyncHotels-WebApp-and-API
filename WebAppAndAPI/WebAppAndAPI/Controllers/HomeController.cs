using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppAndAPI.Models;
using WebAppAndAPI.Models.Interfaces;

namespace WebAppAndAPI.Controllers
{
    public class HomeController : Controller
    {
        private IHotelManager _hotel;

        public HomeController(IHotelManager hotel)
        {
            _hotel = hotel;
        }
        public IActionResult Index()
        {
            return View();
        }

    
    }
}