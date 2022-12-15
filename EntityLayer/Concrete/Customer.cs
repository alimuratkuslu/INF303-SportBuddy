using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Customer
    {

        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string  email { get; set; }
        public string  phone { get; set; }
        public string address { get; set; }
        public DateOnly birth_date { get; set; }

        

    }
}

