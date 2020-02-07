using System;
namespace OOP_Test
{
    public class Auth
    {
        public static string [] user = new string [] {"root","secret"};
        public static int condition = 0;
        public static DateTime loginTime = new DateTime();
        public static void login(string [] User)
        {
            if (User[0] == user[0] && User[1] == User[1])
            {
                Console.WriteLine("Logged in");
                condition = 1;
                loginTime = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Wrong password and/or username");
            }
        }

        public static void validate(string[] User)
        {
            if (User[0] == user[0] && User[1] == User[1] && condition==1)
            {
                Console.WriteLine("Logged in");
                
            }
        }

        public static void logout()
        {
            condition = 0;
            Console.WriteLine("logged out");
        }
        
        public static void _user()
        {
            if(condition==1)
            {
                Console.WriteLine(user[0]);
            }
            else
            {
                Console.WriteLine("log in first");
            }
        }

        public static void check()
        {
            if(condition==1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        public static void guest()
        {
            if (condition == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        public static void lastLogin()
        {
            Console.WriteLine(loginTime);
        }
    }
}
