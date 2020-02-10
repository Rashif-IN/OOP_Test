using System;

namespace OOP_Test
{
    public class Cipher
    {
        static string Message = " ";
        static string realMessage = " ";
        static string Password = " ";

        public static string encrypt(string msg, string pass)
        {
            Message = Hash.sha512(Hash.sha256(Hash.sha1(Hash.md5(msg))));
            realMessage = msg;
            Password = pass;
            Console.WriteLine("Anyone without password can't read this message");
            Log_.PopulateLog("user encrypt a message");
            return Message;

        }

        public static string decrypt(string msg, string pass)
        {
            if (pass == Password && msg== Message)
            {
                Log_.PopulateLog("user decrpyt a message");
                return realMessage;
            }
            else
            {
                Log_.PopulateLog("unknown tried to decrypt message");
                return "Wrong Password";
            }
        }

    }
}
