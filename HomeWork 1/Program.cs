using System;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Как Вас зовут?");

            string name = Console.ReadLine();

            Console.WriteLine($"Привет, {name}, сегодня " + DateTime.Now + );
        }
    }
}
