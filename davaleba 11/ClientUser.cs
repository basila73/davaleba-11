using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba_11
{
    class ClientUser : User
    {
        public ClientUser() : base()
        {
        }

        public ClientUser(string name, string password, string email)
            : base(name, password, email)
        {
        }

        public override void Authorization()
        {
            Console.WriteLine("Client User Authorization");
            Login();
        }
    }
}
