using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Models
{
    public class Property
    {
        public int Id { get; set; }
        public DateTime listDate { get; set; }
        public int bedroomCount { get; set; }
        public int bathroomCount { get; set; }
        public string address { get; set; }
        public bool isSold  { get; set; }
    }
}
