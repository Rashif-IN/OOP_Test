using System;

namespace OOP_Test
{
    public class Cipher
    {
        static string Message = " ";
        static string Password = " ";
        static string Check = "Anyone without password can't read this message";

        public static string encrypt(string msg, string pass)
        {
            Message = msg;
            Password = pass;
            return Check;

        }
        public static string decrypt(string msg, string pass)
        {
            if (pass == Password && msg== Check)
            {
                return Message;
            }
            else
            {
                return "Wrong Password";
            }
        }

    }
}
