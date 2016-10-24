using System;

namespace Basics
{
    // Declare a delegate
    delegate void Del(int i, double j);

    public class DelegateExample
    {
        public void Example(string msg)
        {
            DelegateExample m = new DelegateExample();

            // Delegate instantiation using "MultiplyNumbers"
            Del d = m.MultiplyNumbers;

            // Invoke the delegate object.
            Console.Write("{0}\n\tInvoking the delegate using 'MultiplyNumbers':\n\t", msg);
            for (int i = 1; i <= 5; i++)
            {
                d(i, 2);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private void MultiplyNumbers(int m, double n)
        {
            Console.Write(m * n + " ");
        }
    }
}
