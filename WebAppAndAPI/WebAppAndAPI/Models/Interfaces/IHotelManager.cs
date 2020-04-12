using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAndAPI.Models.Interfaces
{
    interface IHotelManager
    {
        //get all hotels
        Task<List<Hotels>> GetAllHotels();

        //get hotel by ID
        Task GetHotelByID();

    }
}
