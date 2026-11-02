using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba_11
{
    internal abstract class User
    {
        private string name;
        private string password;
        private string email;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        
        public User()
        {
            name = "Unknown";
            password = "0000";
            email = "Unknown";
        }

        public User(string name, string password, string email)
        {
            this.name = name;
            this.password = password;
            this.email = email;
        }

       
        public abstract void Authorization();

        
        public void Login()
        {
            Console.Write("Enter Email: ");
            string enteredEmail = Console.ReadLine();

            Console.Write("Enter Password: ");
            string enteredPassword = Console.ReadLine();

            if (enteredEmail == email && enteredPassword == password)
            {
                Console.WriteLine("Authorization successful!");
            }
            else
            {
                Console.WriteLine("Incorrect Email or Password!");
            }
        }
    }
}

