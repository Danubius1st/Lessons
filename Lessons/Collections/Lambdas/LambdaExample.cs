using System;

namespace Lambdas
{
    delegate int Del(int i);
    delegate void TestDelegate(string s);

    public class LambdaExample
    {
        public LambdaExample(string msg)
        {
            Console.WriteLine("Lambdas {0}", msg);
            LambdaExpression();
            LambdaStatement();
        }
        private void LambdaExpression()
        {
            // (input parameters) => expression
            int par = 5;
            Del myDel = x => x * x;
            Console.WriteLine($"\tx => x * x ({myDel(par)})");
        }

        private void LambdaStatement()
        {
            // (input parameters) => {statement;}
            TestDelegate myDel = n => { string s = n + " " + "World\n"; Console.WriteLine(s); };
            myDel("\tHello");
        }

    }
}
