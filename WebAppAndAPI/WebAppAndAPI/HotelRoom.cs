using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebAppAndAPI
{
    public class HotelRoom
    {

        //composite key
        [JsonPropertyName("hotelId")]
        public int HotelID { get; set; }

        [JsonPropertyName("roomNumber")]
        public int RoomNumber { get; set; }

        //regular table info
        [JsonPropertyName("roomId")]
        public int RoomID { get; set; }

        [JsonPropertyName("petFriendly")]
        public bool PetFriendly { get; set; }

        [JsonPropertyName("rate")]
        public decimal Rate { get; set; }


        //navigation - has 2 foreign keys
        [JsonPropertyName("hotel")]
        public Hotel Hotel { get; set; }
        [JsonPropertyName("room")]
        public Room Room { get; set; }
    }
}
}
