using System;
using System.Threading;

namespace Example1
{
    class Program
    {
        // https://owlcation.com/stem/C-ThreadPool-and-its-Task-Queue-Example

        private static void TaskCallBack(Object ThreadNumber)
        {
            string ThreadName = "Thread " + ThreadNumber.ToString();
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine(ThreadName + ": " + i.ToString());
            }
            Console.WriteLine(ThreadName + " Finished...");
        }

        static void Main(string[] args)
        {
            for (int task = 1; task < 11; task++)
            {
                _ = ThreadPool.QueueUserWorkItem(new WaitCallback(TaskCallBack), task);
            }
            //Thread.Sleep(10000);
            _ = Console.ReadKey();
        }
    }
}
