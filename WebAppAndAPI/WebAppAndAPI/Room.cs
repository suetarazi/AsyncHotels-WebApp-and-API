using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebAppAndAPI
{
    public class Room
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        //Refers to enum below for layout types
        [JsonPropertyName("layout")]
        public Layout Layout { get; set; }

        //Navigation properties
        [JsonPropertyName("roomAmenities")]
        public List<RoomAmenities> RoomAmenities { get; set; }

        [JsonPropertyName("hotelRoom")]
        public List<HotelRoom> HotelRoom { get; set; }
    }

    //This is the Enum for the Layout property above
    public enum Layout
    {
        Studio,
        OneBedroom,
        TwoBedroom,
        StudioADA,
        OneBedroomADA,
        TwoBedroomADA
    }
}
}
