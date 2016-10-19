using System;
using System.Collections;

namespace Collections
{
    public class ArrayListExample
    {
        private ArrayList apList;

        public ArrayList ApList
        {
            get { return apList; }
            set { apList = value; }
        }

        public ArrayListExample()
        {
            apList = new ArrayList();

            ApList.Add("one");
            ApList.Add("two");
            ApList.Add("four");
            ApList.Insert(2, "three");
        }

        public void DisplayAp(string msg)
        {
            Console.WriteLine(msg + ":");
            foreach (var ap in apList)
            {
                Console.WriteLine("\t{0}", ap);
            }
            Console.ReadLine();
        }

        public void DisplayAp(string msg, int item)
        {
            Console.WriteLine(msg + ":");
            Console.WriteLine("\tElement[{0}]: {1}", item, apList[item]);
            Console.ReadLine();
        }

        public void CheckItem(string msg, string item)
        {
            Console.WriteLine(msg + ":");
            Console.WriteLine(string.Format("\tThe list {0}contains element: {1}", apList.Contains(item) ? "" : "does not ", item));
            Console.ReadLine();
        }

        public void DisplayIndexOf(string msg, object item)
        {
            Console.WriteLine(msg + ":");
            Console.WriteLine("\tIndexOf(\"{0}\"): {1}", item, apList.IndexOf(item));
            Console.ReadLine();
        }
    }
}
