using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Customer
    {

        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string name { get; set; }
        public string surname { get; set; }
        public string  email { get; set; }
        public string  phone { get; set; }
        public string address { get; set; }
        public DateOnly birth_date { get; set; }

        public string username { get; set; }
        public string password { get; set; }

        public virtual ICollection<Activity> Main_Activity { get; set; }
        public virtual ICollection<Activity> Buddy_Activity { get; set; }

    }
}

