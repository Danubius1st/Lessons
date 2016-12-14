using System;

namespace Basics
{
    public class TypeCodeExample
    {
        public TypeCodeExample(string msg)
        {
            bool Unu = true;
            double Doi = 2.0;
            string Trei = "ceva";

            Console.WriteLine("Basics - {0}", msg);
            WriteObjectInfo(Unu);
            WriteObjectInfo(Doi);
            WriteObjectInfo(Trei);
            Console.WriteLine();
        }

        static void WriteObjectInfo(object testObject)
        {
            TypeCode typeCode = Type.GetTypeCode(testObject.GetType());

            switch (typeCode)
            {
                case TypeCode.Boolean:
                    Console.WriteLine("\tBoolean: {0}", testObject);
                    break;

                case TypeCode.Double:
                    Console.WriteLine("\tDouble: {0}", testObject);
                    break;

                default:
                    Console.WriteLine("\t{0}: {1}", typeCode.ToString(), testObject);
                    break;
            }
        }
    }
}
