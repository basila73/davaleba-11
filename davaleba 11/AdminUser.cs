using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba_11
{
    internal class AdminUser : User
    {
        public AdminUser() : base()
        {
        }
        public AdminUser(string name, string password, string email)
            : base(name, password, email)
        {
        }
        public override void Authorization()
        {
            Console.WriteLine("Admin User Authorization");
            Login();
        }
  
    }
}
