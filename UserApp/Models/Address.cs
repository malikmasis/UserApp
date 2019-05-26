using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public AddressType AddressType { get; set; }
        public int UserId { get; set; }


        public virtual User User { get; set; }
    }

    public enum AddressType{
        Home,
        Work,
        School
    }
}