using System;

namespace MaskSensitiveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's talk secrets. What's yours?");
            var secret = Console.ReadLine();

            var maskedString = new String('X', secret.Length - 4) + secret.Substring(secret.Length - 4);

            Console.WriteLine(maskedString);
            Console.ReadLine();
        }
    }
}
