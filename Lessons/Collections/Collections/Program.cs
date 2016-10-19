using System;
using Basics;
using LinqExpressions;

namespace Collections
{
    class Program
    {
        static void DisplayCollections()
        {
            int test = -1;
            while (test != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Collections - Enter exercise no: (1 to 4) ");
                string input = Console.ReadLine();

                System.Console.Clear();
                int.TryParse(input, out test);
                Console.ForegroundColor = ConsoleColor.Green;
                switch (test)
                {
                    case 0:
                        break;

                    case 1:
                        ArrayListExample ex1 = new ArrayListExample();
                        ex1.DisplayAp("ex1.1 - array list iteration");

                        ex1.ApList.RemoveAt(1);
                        ex1.DisplayAp("ex1.2 - using RemoveAt");

                        ex1.DisplayAp("ex1.3 - using indexes", 2);

                        ex1.CheckItem("ex1.4 - using Contains", "one");
                        ex1.CheckItem("ex1.5 - using Contains", "five");

                        ex1.DisplayIndexOf("ex1.6 - using IndexOf", "five");
                        ex1.DisplayIndexOf("ex1.7 - using IndexOf", 0);
                        ex1.DisplayIndexOf("ex1.8 - using IndexOf", "four");

                        ex1.ApList.Sort();
                        ex1.DisplayAp("ex1.9 - sorted array list");

                        ex1.ApList.Reverse();
                        ex1.DisplayAp("ex1.10 - reverse sorted array list");
                        break;

                    case 2:
                        ArrayExample ex2 = new ArrayExample();
                        ex2.DisplayNumbersLength("ex2.1 - Array's length");
                        break;

                    case 3:
                        string[] Msg = { "ex3.1 - Strongly Typed List", "ex3.2 - Strongly Typed Dictionary" };
                        StronglyTypedList ex3 = new StronglyTypedList(Msg);
                        break;

                    case 4:
                        LinkedListExample ex4 = new LinkedListExample("ex. 4.{0} - LinkedList");
                        break;

                    default:
                        Console.WriteLine("Not implemented!");
                        break;
                }
            }
        }

        static void DisplayBasics()
        {
            TypeCodeExample tc = new TypeCodeExample("ex1.1 - TypeCode Enumeration");
            NullCoalescingOperatorExample nco = new NullCoalescingOperatorExample("ex1.2 - Null Coalescing Operator");
            FormatExample fe = new FormatExample("ex1.3 - Format");
        }

        static void DisplayLinqExpressions()
        {
            LinqClass Lq = new LinqClass("Linq expressions - ");
        }

        static void Main(string[] args)
        {
            int test = -1;
            while (test != 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Basics (1)\nCollections (2)\nLinq (3)\n0 - exit: ");
                string input = Console.ReadLine();

                System.Console.Clear();
                int.TryParse(input, out test);
                Console.ForegroundColor = ConsoleColor.Green;
                switch (test)
                {
                    case 0:
                        break;

                    case 1:
                        DisplayBasics(); //test = -1;
                        break;

                    case 2:
                        DisplayCollections(); test = -1;
                        break;

                    case 3:
                        DisplayLinqExpressions(); //test = -1;
                        break;

                    default:
                        Console.WriteLine("Not implemented!");
                        break;
                }
            }
        }
    }
}
