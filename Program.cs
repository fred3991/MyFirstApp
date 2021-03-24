using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write(" Type your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello "+ name + "!");
            Console.Read();
            Console.Clear();
            Console.ReadLine();
        }
    }
}
