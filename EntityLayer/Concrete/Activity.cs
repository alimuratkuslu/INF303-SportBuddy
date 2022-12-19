using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Activity
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int activity_id { get; set; }

        
        public int user1_id { get; set; }
                
        public int user2_id { get; set; }
             
        public DateTime time { get; set; }

        
        public int location_id { get; set; }
           

        public int duration { get; set; }
        public int rating_location { get; set; }
        public int rating_buddy { get; set; }
        public int rating_time { get; set; }
        public string comment { get; set; }
        public string status { get; set; }

        [ForeignKey(nameof(user1_id))]
        public Customer user1 { get; set; }

        [ForeignKey(nameof(user2_id))]
        public Customer user2 { get; set; }

        [ForeignKey(nameof(location_id))]
        public Location Location { get; set; }


    }
}

