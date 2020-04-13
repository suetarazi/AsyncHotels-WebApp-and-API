using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebAppAndAPI
{
    public class Amenities
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }


        //Navigation property
        [JsonPropertyName("roomAmenities")]
        public ICollection<RoomAmenities> RoomAmenities { get; set; }
    }
}
