using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class TestOperator
    {
        public TestOperator(string Msg, int? No)
        {
            Console.WriteLine($"Basics - {Msg} : {No.ToString()}");
        }
    }
}
