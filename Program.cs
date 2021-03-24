using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // с переносом на след строку
            Console.Write(" Type your name: "); // без переноса
            string name = Console.ReadLine(); // чтение имени в память
            Console.WriteLine("Hello "+ name + "!"); // новая строка + переменная
            Console.Read(); // считывает только один символ 
            Console.Clear(); // очистка
            Console.ReadLine(); // 
        }
    }
}
