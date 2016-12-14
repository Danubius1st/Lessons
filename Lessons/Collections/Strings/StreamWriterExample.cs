using System;
using System.IO;

namespace Strings
{
    public class StreamWriterExample
    {

        public StreamWriterExample(string Msg)
        // https://msdn.microsoft.com/en-us/library/system.io.streamwriter%28v=vs.110%29.aspx?f=255&MSPPError=-2147217396
        {
            Console.WriteLine("\n{0}: - StreamWriter", Msg);
            // Get the directories current directory.
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();
            string FileName = "CDriveDirs.txt";

            // Write each directory name to a file.
            using (StreamWriter sw = new StreamWriter(FileName))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name); // writes in Directory.GetCurrentDirectory()
                }
            }

            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader(FileName))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine("\t\t" + line);
                }
            }
            File.Delete(FileName);
        }
    }
}
