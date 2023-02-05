using System;

namespace Task2
{
    internal class Logger : ILogger
    {
        public void Error(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.GetType().ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Event(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Сумма равна: {x + y}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
