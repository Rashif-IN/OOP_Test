using System;
using System.Text;
using System.Security.Cryptography;


namespace OOP_Test
{

    class Program
    {
        static void Main(string[] args)
        {
            //num1
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

            //num2
            string msg = Cipher.encrypt("I am you father", "WARMACHINER0CKS");
            Console.WriteLine(msg);

            string dmsg = Cipher.decrypt(msg, "XXX");
            Console.WriteLine(dmsg);

            string dmsg2 = Cipher.decrypt(msg, "WARMACHINER0CKS");
            Console.WriteLine(dmsg2);

            string dmsg3 = Cipher.decrypt("4b121781f87a4cc9880cb8c599f83c999f2b55a38c87749be5d782107d358cd8357fdca8c3763b857a5e5598beb58c083c6fc72006903bf026e6a3d4f0a569a2", "WARMACHINER0CKS");
            Console.WriteLine(dmsg3);


            

            //num4
            Auth.login("root", "secret");
            Auth.validate( "root", "secret" );
            Auth.ID();
            Auth._user();
            Auth.check();
            Auth.guest();
            Auth.lastLogin();
            Auth.logout();
            Auth.guest();




            //num5
            Cart newcart = new Cart();

            newcart.AddItem(356, 10000, 6)
                .AddItem(983, 10000, 2)
                .AddItem(543, 10000, 7)
                .RemoveItem(983)
                .AddDiscount(30);


            Cart.TotalItems();
            Cart.TotalQuantity();
            Cart.TotalPrice();
            Cart.ShowAllItems();
            Cart.Checkout();

            //num3
            Log_.SaveAllLog();
        }
    }
}
