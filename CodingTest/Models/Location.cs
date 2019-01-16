using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodingTest.Models
{
    public class Location
    {
        public Location()
        {
            ChildrenLocations = new List<Location>();
        }

        public string Name { get; set; }
        
        public List<Location> ChildrenLocations { get; set; }
    }
}