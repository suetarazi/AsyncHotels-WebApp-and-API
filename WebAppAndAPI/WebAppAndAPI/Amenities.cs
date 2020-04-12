﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAndAPI
{
    public class Amenities
    {

        public int ID { get; set; }

        public string Name { get; set; }


        //Navigation property
        public ICollection<RoomAmenities> RoomAmenities { get; set; }
    }
}
