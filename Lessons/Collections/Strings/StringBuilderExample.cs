using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class StringBuilderExample
    {
        public StringBuilderExample(string Msg)
        {
            // https://msdn.microsoft.com/en-us/library/2839d5h5(v=vs.110).aspx?f=255&MSPPError=-2147217396&cs-save-lang=1&cs-lang=csharp#code-snippet-6
            Console.WriteLine("\n{0}: - StringBuilder", Msg);
            AppendExample();
            AppendFormatExample();
            InsertExample();
            RemoveExample();
            ReplaceExample();
            ConvertingExample();
        }

        private void AppendExample()
        {
            StringBuilder sb = new StringBuilder("\n\tAppend example: Hello World!");
            sb.Append(" What a beautiful day.");
            Console.WriteLine(sb);
        }

        private void AppendFormatExample()
        {
            StringBuilder sb = new StringBuilder("\tAppendFormat example: Your total is ");
            int Value = 25;
            sb.AppendFormat("{0:C} ", Value);
            Console.WriteLine(sb);
        }

        private void InsertExample()
        {
            StringBuilder sb = new StringBuilder("\tInsert example: Hello World!");
            sb.Insert(23, "Beautiful ");
            Console.WriteLine(sb);
        }

        private void RemoveExample()
        {
            StringBuilder sb = new StringBuilder("\tRemove example: Hello World!");
            sb.Remove(22, 6);
            Console.WriteLine(sb);
        }

        private void ReplaceExample()
        {
            StringBuilder sb = new StringBuilder("\tReplace example: Hello World!");
            sb.Replace('!', '?');
            Console.WriteLine(sb);
        }

        private void ConvertingExample()
        {
            StringBuilder sb = new StringBuilder();
            bool flag = true;
            string[] spellings = { "recieve", "receeve", "receive" };
            sb.AppendFormat("Converting example: Which of the following spellings is {0}:", flag);
            sb.AppendLine();
            for (int i = 0; i <= spellings.GetUpperBound(0); i++)
            {
                sb.AppendFormat("\t\t{0}. {1}", i, spellings[i]);
                sb.AppendLine();
            }
            sb.AppendLine();
            Console.WriteLine("\t" + sb.ToString());
        }
    }
}
