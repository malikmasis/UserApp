using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserApp.Models
{
    public class User
    {
            public int Id { get; set; }
            public string FirstMidName { get; set; }
            public string LastName { get; set; }
            public DateTime Birthday { get; set; }
            public string MobilePhone { get; set; }
            public string Email { get; set; }

            public virtual ICollection<Address> Addresses { get; set; }
    }
}