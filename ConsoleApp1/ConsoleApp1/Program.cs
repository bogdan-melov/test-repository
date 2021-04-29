using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER YOUT NAME");

            var name = Console.ReadLine();
            var surname = Console.ReadLine();

            Console.WriteLine("Hello {0}!", name );
        }
    }
}
