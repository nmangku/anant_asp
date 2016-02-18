using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }
        public string LocationAddress { get; set; }
        public int LocationLatitude { get; set; }
        public int LocationLongitude { get; set; }
    }
}