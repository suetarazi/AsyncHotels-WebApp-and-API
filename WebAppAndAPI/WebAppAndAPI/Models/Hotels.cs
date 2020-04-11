using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAndAPI.Models
{
    public class Hotels
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PhoneNumber { get; set; }

        //not sure about including HotelRoomDTO - do we need it to return a list of hotels or info about a specific hotel?
        //public List<HotelRoomDTO> Rooms { get; set; }

    }
}
