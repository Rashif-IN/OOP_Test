using System;
namespace OOP_Test
{
    public class Auth
    {
        public static string user = "root";
        public static string password = "secret";
        public static string id = "rx-178";
        public static int condition = 0;
        public static DateTime loginTime = new DateTime();

        

        public static void login(string User, string Password)
        { 
            if (User == user && Password == password)
            {
                Console.WriteLine("Logged in");
                Log_.PopulateLog("Logged in");
                condition = 1;
                loginTime = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Wrong password and/or username");
                Log_.PopulateLog("unknown tried to log in");
            }
        }

        public static void validate(string User, string Password)
        {
            if (User == user && Password == password && condition == 1)
            {
                Console.WriteLine("Already Logged in");
                Log_.PopulateLog("user validated");
            }
            else
            {
                Console.WriteLine("Log in first");
                Log_.PopulateLog("unkonwn tried to validate");
            }
        }

        public static void ID()
        {
            if(condition==1)
            {
                Console.WriteLine(id);
                Log_.PopulateLog("user request id");
            }
            else
            {
                Console.WriteLine("log in first");
                Log_.PopulateLog("unkonwn tried to request id");
            }
        }

        public static void logout()
        {
            condition = 0;
            Console.WriteLine("logged out");
            Log_.PopulateLog($"{user} logged out");
        }
        
        public static void _user()
        {
            if(condition==1)
            {
                Console.WriteLine(user[0]);
                Log_.PopulateLog($"{user} shows username");
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
                Log_.PopulateLog($"{user} is logged in");
            }
            else
            {
                Console.WriteLine(false);
                Log_.PopulateLog("unknown tried to check");
            }
        }
        public static void guest()
        {
            if (condition == 0)
            {
                Console.WriteLine(true);
                Log_.PopulateLog("guest is user");
            }
            else
            {
                Console.WriteLine(false);
                Log_.PopulateLog($"{user} is logged in");
            }
        }
        public static void lastLogin()
        {
            Console.WriteLine(loginTime);
            Log_.PopulateLog($"{user} last log in");
        }
    }
}
