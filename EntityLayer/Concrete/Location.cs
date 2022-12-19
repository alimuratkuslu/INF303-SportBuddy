using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Location
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int location_id { get; set; }

        
        public string city { get; set; }
        public string district { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public int rating { get; set; }
        public string workhours { get; set; }
        public string status { get; set; }

        public virtual ICollection<Activity> Activity { get; set; }

    }
}

