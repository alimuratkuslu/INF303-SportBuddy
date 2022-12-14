using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Activity
    {
        [Key]
        public int activityId { get; set; }
        public int user1Id { get; set; }
        public Customer Customer1 { get; set; }
        public int user2Id { get; set; }
        public Customer Customer2 { get; set; }
        public DateTime time { get; set; }
        public int locationId { get; set; }
        public Location Location { get; set; }
        public int duration { get; set; }
        public int ratingLocation { get; set; }
        public int ratingBuddy { get; set; }
        public int ratingTime { get; set; }
        public string comment { get; set; }
        public string status { get; set; }
    }
}

