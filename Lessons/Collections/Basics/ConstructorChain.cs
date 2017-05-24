using System;

namespace Basics
{
    public class ConstructorChain
    {
        // http://stackoverflow.com/questions/10166531/how-do-i-edit-the-mainwindow-constructor-of-a-wpf-application
        // http://stackoverflow.com/questions/15054044/wpf-mainwindow-that-takes-parameters
        // https://social.msdn.microsoft.com/Forums/en-US/e15be817-42d2-4600-82e6-46d5081858b7/constructor-chaining-in-c?forum=csharplanguage
        // http://www.c-sharpcorner.com/UploadFile/825933/constructor-chaining-in-C-Sharp/

        public ConstructorChain(int No)
        {
            Console.WriteLine($"Constructor with numeric parameter: {No}");
        }

        public ConstructorChain(string Msg)
        {
            Console.WriteLine(Msg);
        }

        public ConstructorChain(string Msg, int No)
        {
            Console.WriteLine($"\tConstructor with parameters (\"{Msg}\" and \"{No}\") called by constructor base");
        }

        public ConstructorChain() : this("Test", 20)
        {
            Console.WriteLine("\tConstructor base\n");
        }
    }
}
