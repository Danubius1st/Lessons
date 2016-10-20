using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class LambdaExpressions
    {
        public delegate int Del(int i);

        public LambdaExpressions(string msg)
        {
            int parm = 5;
            Console.WriteLine("Lambdas {0}", msg);
            Console.WriteLine($"\tx => x * x ({SimpleExpression(parm)})");
        }

        private int SimpleExpression(int par)
        {
            Del myDelegate = x => x * x;
            int result = myDelegate(par);

            return result;
        }

        public static implicit operator LambdaExpression(LambdaExpressions v)
        {
            throw new NotImplementedException();
        }
    }
}
