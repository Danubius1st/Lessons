using System;
using Basics;
using Lambdas;
using LinqExpressions;
using Strings;

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
            int test = -1;
            while (test != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Basics - Enter exercise no: (1 to 4) ");
                string input = Console.ReadLine();

                System.Console.Clear();
                int.TryParse(input, out test);
                Console.ForegroundColor = ConsoleColor.Green;
                switch (test)
                {
                    case 0:
                        break;

                    case 1:
                        TypeCodeExample tc = new TypeCodeExample("ex. 1.1 - TypeCode Enumeration");
                        NullCoalescingOperatorExample nco = new NullCoalescingOperatorExample("ex1.2 - Null Coalescing Operator");
                        FormatExample fe = new FormatExample("ex. 1.3 - Format");
                        DelegateExample del = new DelegateExample(); del.Example("ex. 1.4 - Delegates");
                        del.Example();
                        break;

                    case 2:
                        DelegateExample del2 = new DelegateExample(); del2.ActionExample("ex. 2.1 - Actions / Delegates\n");
                        break;

                    case 3:
                        DelegateExample del3 = new DelegateExample(); del3.AnonymousExample("ex.3.2 - Actions / Delegates - anonymous\n");
                        break;

                    case 4:
                        DelegateExample del4 = new DelegateExample(); del4.LambdaExample("ex. 4.1 - Actions / Delegates - lambdas\n");
                        break;

                    default:
                        Console.WriteLine("Not implemented!");
                        break;
                }
            }
        }

        static void DisplayLambdaExpressions()
        {
            int test = -1;
            while (test != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Lambdas - Enter exercise no: (1 to 4) ");
                string input = Console.ReadLine();

                System.Console.Clear();
                int.TryParse(input, out test);
                Console.ForegroundColor = ConsoleColor.Green;
                switch (test)
                {
                    case 0:
                        break;

                    case 1:
                        LambdaExample lmbd = new LambdaExample("ex. 1.1");
                        break;

                    case 2:
                        Console.WriteLine("Not implemented!");
                        break;

                    case 3:
                        Console.WriteLine("Not implemented!");
                        break;

                    case 4:
                        Console.WriteLine("Not implemented!");
                        break;

                    default:
                        Console.WriteLine("Not implemented!");
                        break;
                }
            }
        }

        static void DisplayLinqExpressions()
        {
            int test = -1;
            while (test != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Linq - Enter exercise no: (1 to 4) ");
                string input = Console.ReadLine();

                System.Console.Clear();
                int.TryParse(input, out test);
                Console.ForegroundColor = ConsoleColor.Green;
                switch (test)
                {
                    case 0:
                        break;

                    case 1:
                        LinqClass Lq = new LinqClass("Linq expressions - ");
                        break;

                    case 2:
                        Console.WriteLine("Not implemented!");
                        break;

                    case 3:
                        Console.WriteLine("Not implemented!");
                        break;

                    case 4:
                        Console.WriteLine("Not implemented!");
                        break;

                    default:
                        Console.WriteLine("Not implemented!");
                        break;
                }
            }
        }

        static void DisplayStrings()
        {
            int test = -1;
            while (test != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Strings - Enter exercise no: (1 to 4) ");
                string input = Console.ReadLine();

                System.Console.Clear();
                int.TryParse(input, out test);
                Console.ForegroundColor = ConsoleColor.Green;
                switch (test)
                {
                    case 0:
                        break;

                    case 1:
                        StringReaderExample ex1 = new StringReaderExample("ex. 5.1");
                        ex1.ReaderExample();
                        ex1.WriterExample();
                        break;

                    case 2:
                        StringBuilderExample ex2 = new StringBuilderExample("ex. 5.2");
                        break;

                    case 3:
                        StreamWriterExample ex3= new StreamWriterExample("ex. 5.3");
                        break;

                    case 4:
                        Console.WriteLine("Not implemented!");
                        break;

                    default:
                        Console.WriteLine("Not implemented!");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            int test = -1;
            while (test != 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Basics (1)\nCollections (2)\nLambdas (3)\nLinq (4)\nStrings (5)\n0 - exit: ");
                string input = Console.ReadLine();

                System.Console.Clear();
                int.TryParse(input, out test);
                Console.ForegroundColor = ConsoleColor.Green;
                switch (test)
                {
                    case 0:
                        break;

                    case 1:
                        DisplayBasics();
                        break;

                    case 2:
                        DisplayCollections();
                        break;

                    case 3:
                        DisplayLambdaExpressions();
                        break;
                        ;
                    case 4:
                        DisplayLinqExpressions();
                        break;

                    case 5:
                        DisplayStrings();
                        break;

                    default:
                        Console.WriteLine("Not implemented!");
                        break;
                }
            }
        }
    }
}
