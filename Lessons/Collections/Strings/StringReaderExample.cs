using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class StringReaderExample
    {
        private readonly string _textReaderText;
        private string _aParagraph;

        public StringReaderExample(string Msg)
        // https://msdn.microsoft.com/en-us/library/system.io.stringwriter(v=vs.110).aspx
        {
            _textReaderText = "TextReader is the abstract base " +
            "class of StreamReader and StringReader, which read " +
            "characters from streams and strings, respectively.\n\n" +

            "Create an instance of TextReader to open a text file " +
            "for reading a specified range of characters, or to " +
            "create a reader based on an existing stream.\n\n" +

            "You can also use an instance of TextReader to read " +
            "text from a custom backing store using the same " +
            "APIs you would use for a string or a stream.\n\n";

            Console.WriteLine("\n\t{0} Original text:\n\n{1}", Msg, _textReaderText);
        }

        public void ReaderExample()
        {
            StringReader strReader = new StringReader(_textReaderText);
            _aParagraph = null;
            while (true)
            {
                string aLine = strReader.ReadLine();
                if (aLine != null)
                {
                    _aParagraph = _aParagraph + aLine + " ";
                }
                else
                {
                    _aParagraph = _aParagraph + "\n";
                    break;
                }
            }

            Console.WriteLine("\tStringReader (line by line): Modified text:\n\n{0}", _aParagraph);
        }

        public void WriterExample()
        {
            // Re-create textReaderText from aParagraph.
            StringReader strReader = new StringReader(_textReaderText);
            StringWriter strWriter = new StringWriter();
            strReader = new StringReader(_aParagraph);
            while (true)
            {
                int intCharacter = strReader.Read();

                // Check for the end of the string 
                // before converting to a character.
                if (intCharacter == -1) break;

                char convertedCharacter = Convert.ToChar(intCharacter);
                if (convertedCharacter == '.')
                {
                    strWriter.Write(".\n\n");

                    // Bypass the spaces between sentences.
                    strReader.Read();
                    strReader.Read();
                }
                else
                {
                    strWriter.Write(convertedCharacter);
                }
            }
            Console.WriteLine("\n\tStringWriter (char by char): Original text:\n\n{0}", strWriter.ToString());
        }
    }
}
