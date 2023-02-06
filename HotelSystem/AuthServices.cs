using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    internal class AuthServices
    {
        public DB DB { get; set; } = new DB();
        public IList<Admin> Admins { get; set; } = new List<Admin>();
        public IList<Customer> Customers { get; set; } = new List<Customer>(); 

        public static void LogInAdmin(string email, string password)
        {
            var admin = DB.Admins.FirstOrDefault(a => a.EmailAddress== email);

            if(admin != null)
            {
                var passcode = DB.Admins.FirstOrDefault(a=> a.Password== password);
                if(passcode != null)
                {
                    Services.Admin();
                }
            }
        }
        public  static void LogInCustomer(string email, string password)
        {
            var customers = DB.Customers.FirstOrDefault(a => a.EmailAddress == email);

            if (customers != null)
            {
                var passcode = DB.Customers.FirstOrDefault(a => a.Password == password);
                if (passcode != null)
                {
                    Services.Customer();
                }
            }
        }

        public void CreateAnAdminAccount(Admin admin)
        {
            Admins.Add(admin);
            
        }
        public void CreateACustomerAccount(Customer customer)
        {
            Customers.Add(customer);
        }

    }
}
