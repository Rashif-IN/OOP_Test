using System;
using System.Text;
using System.Security.Cryptography;


namespace OOP_Test
{

    class Program
    {
        static void Main(string[] args)
        {
            //string plainData = "secret";
            //Console.WriteLine("Raw data: {0}", plainData);

            //string hashedmd5 = Hash.md5(plainData);
            //Console.WriteLine("md5 {0}", hashedmd5);
            //Console.WriteLine(" ");
            //string hashedsha1 = Hash.sha1(plainData);
            //Console.WriteLine("sha1 {0}", hashedsha1);
            //Console.WriteLine(" ");
            //string hashedsha256 = Hash.sha256(plainData);
            //Console.WriteLine("sha256 {0}", hashedsha256);
            //Console.WriteLine(" ");
            //string hashedsha512 = Hash.sha512(plainData);
            //Console.WriteLine("sha512 {0}", hashedsha512);
            //Console.WriteLine(" ");

            //string msg = Cipher.encrypt("I am you father", "WARMACHINER0CKS");
            //Console.WriteLine(msg);

            //string dmsg = Cipher.decrypt(msg, "XXX");
            //Console.WriteLine(dmsg);

            //string dmsg2 = Cipher.decrypt(msg, "WARMACHINER0CKS");
            //Console.WriteLine(dmsg2);


            Auth.login(new string [] {"root","secret" });
            Auth.validate(new string[] { "root", "secret" });
            Auth._user();
            Auth.check();
            Auth.guest();
            Auth.lastLogin();
            Auth.logout();
            Auth.guest();
        }
    }
}
