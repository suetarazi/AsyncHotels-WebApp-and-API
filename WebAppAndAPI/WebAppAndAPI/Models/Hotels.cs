using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAndAPI.Models
{
    public class Hotels
    {
        //4/12/20 - insert JSON annotations
        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PhoneNumber { get; set; }

        //not sure about including HotelRoomDTO - do we need it to return a list of hotels or info about a specific hotel?
       // public List<HotelRoom> Rooms { get; set; }

    }
}
