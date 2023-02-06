using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    internal class DB
    {
        public static IList<Admin> Admins { get; set; } = new List<Admin>() 
        {
            new Admin(){Name = "Amaka", EmailAddress = "Amy123@gmail.com", Password = "1234" },
            new Admin(){Name = "Emeka", EmailAddress = "Emmy123@gmail.com", Password = "1234" },
            new Admin(){Name = "Adaka", EmailAddress = "Ady123@gmail.com", Password = "1234" },
        };
        public static IList<Customer> Customers { get; set; } = new List<Customer>() 
        {
            new Customer(){ Name = "Onah", EmailAddress = "bossmi123@gmail.com", Password = "1234"},
            new Customer(){ Name = "Alex", EmailAddress = "king123@gmail.com", Password = "1234"},
            new Customer(){ Name = "Obinna", EmailAddress = "slimscent@gmail.com", Password = "1234"},
        };


    }
}
