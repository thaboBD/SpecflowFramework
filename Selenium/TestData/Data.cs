using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.TestData
{
    public class Data
    {
        private static string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private static string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
