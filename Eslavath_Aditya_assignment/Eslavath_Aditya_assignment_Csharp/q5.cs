using System;
using System.Collections.Generic;
using System.Text;

namespace Eslavath_Aditya_assignment_Csharp
{
    class User
    {
        public string UserName;
        public string Password;
        public string Role;
    }

    class Security
    {
        User[] users = new User[5];

        public Security()
        {
            users[0] = new User { UserName = "admin", Password = "admin123", Role = "Administrator" };
            users[1] = new User { UserName = "manager", Password = "manager123", Role = "Manager" };
            users[2] = new User { UserName = "user1", Password = "pass1", Role = "User" };
            users[3] = new User { UserName = "user2", Password = "pass2", Role = "User" };
            users[4] = new User { UserName = "guest", Password = "guest123", Role = "Guest" };
        }

        public bool ValidateUser(User u)
        {
            foreach (User user in users)
            {
                if (user.UserName == u.UserName && user.Password == u.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }

    internal class q5
    {
        static void Main(string[] args)
        {
            Security security = new Security();

            User inputUser = new User();

            Console.Write("Enter Username: ");
            inputUser.UserName = Console.ReadLine();

            Console.Write("Enter Password: ");
            inputUser.Password = Console.ReadLine();

            bool result = security.ValidateUser(inputUser);

            if (result)
                Console.WriteLine("Login Successful");
            else
                Console.WriteLine("Login Failed");
        }
    }
}
