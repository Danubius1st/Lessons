using System;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new HandyDandyApplication();
            app.DisplayUsers(Console.Out);

            Console.Read();
        }
    }
}
