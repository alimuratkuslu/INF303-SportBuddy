using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Location
    {
        [Key]
        public int locationId { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public int rating { get; set; }
        public string workingHours { get; set; }
        public string status { get; set; }

    }
}

