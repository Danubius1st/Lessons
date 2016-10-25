using System;

namespace Basics
{
    // Declare a delegate
    delegate void Del(int i, double j);
    delegate void DelNtf(string str);

    public class DelegateExample
    {
        private const string _format = "\tNotification received for: {0}";

        public void Example(string msg)
        {
            // https://msdn.microsoft.com/en-us/library/98dc08ac.aspx
            DelegateExample m = new DelegateExample();

            // Delegate instantiation using "MultiplyNumbers"
            Del d = m.MultiplyNumbers;

            // Invoke the delegate object.
            Console.Write("{0}\n\tInvoking the delegate using 'MultiplyNumbers':\n\t", msg);
            for (int i = 1; i <= 5; i++)
            {
                d(i, 2);
            }
            Console.WriteLine();
        }

        public void Example()
        {
            // https://msdn.microsoft.com/en-us/library/ms173176.aspx
            DelNtf del1 = new DelNtf(Notify); del1.Invoke("\t1");
            DelNtf del2 = Notify; del2.Invoke("\t2");
            // Instantiate Del by using an anonymous method.
            DelNtf del3 = delegate(string name)
            {
                Console.WriteLine(_format, name);
            };
            del3.Invoke("\t3");
            // Instantiate Del by using a lambda expression.
            DelNtf del4 = name => { Console.WriteLine(_format, name); };
            del4.Invoke("\t4");

            // https://msdn.microsoft.com/en-us/library/ms173175.aspx
            DelNtf hiDel, byeDel, multiDel, multiMinusHiDel;
            hiDel = Hello;
            byeDel = Goodbye;
            multiDel = hiDel + byeDel;
            multiMinusHiDel = multiDel - hiDel;

            Console.Write("\tInvoking delegate hiDel:"); hiDel("A\n");
            Console.Write("\tInvoking delegate byeDel:"); byeDel("B\n");
            Console.Write("\tInvoking delegate multiDel:"); multiDel("C");
            Console.Write("\n\tInvoking delegate multiMinusHiDel:"); multiMinusHiDel("D\n\n");
        }

        private void MultiplyNumbers(int m, double n)
        {
            Console.Write(m * n + " ");
        }

        static void Notify(string name)
        {
            Console.WriteLine(_format, name);
        }

        static void Hello(string s)
        {
            Console.Write("  Hello, {0}", s);
        }

        static void Goodbye(string s)
        {
            Console.Write("  Goodbye, {0}", s);
        }
    }
}
