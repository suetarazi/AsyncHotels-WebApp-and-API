using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppAndAPI.Models.Interfaces;

namespace WebAppAndAPI.Controllers
{
    public class HotelsController : Controller
    {
        private IHotelManager _hotel;

        public HotelsController(IHotelManager hotel)
        {
            _hotel = hotel;
        }
        public IActionResult Index()
        {
            return View();
        }
        //two post routes to return all hotels
        [HttpPost]
        public async Task<IActionResult> Index(int hotel)
        {
            //return RedirectToAction("Results", new { hotels });
            var result = await _hotel.GetAllHotels();
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Results(int hotelId)
        {
            //   List<Hotels> hotels = //query for all hotels here

            // return View(hotels);
            var result = await _hotel.GetHotelByID(hotelId);
            return View(result);
        }


    }
}