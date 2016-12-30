using System;

namespace Basics
{
    public class OperatorExample
    {
        public OperatorExample(string msg)
        {
            Console.WriteLine(msg);
            Example a = new Example(1, 2);
            Example b = new Example(3, 7);
            Example c = new Example(2, 3);
            Console.WriteLine((double)(a* b + c));
        }
    }

    internal class Example
    {
        //
        //operator (C# Reference)
        //https://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k(operator_CSharpKeyword);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.5.2);k(DevLang-csharp)&rd=true
        //
        private readonly int _num, _den;

        public Example(int num, int den)
        {
            _num = num;
            _den = den;
        }

        // overload operator +
        public static Example operator +(Example a, Example b)
        {
            return new Example(a._num * b._den + b._num * a._den, a._den * b._den);
        }

        // overload operator *
        public static Example operator *(Example a, Example b)
        {
            return new Example(a._num * b._num, a._den * b._den);
        }

        // user-defined conversion from Fraction to double
        public static implicit operator double(Example f)
        {
            return (double)f._num / f._den;
        }
    }
}
