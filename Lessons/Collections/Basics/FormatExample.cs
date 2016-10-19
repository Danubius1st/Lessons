using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Basics
{
    public class FormatExample
    {
        public FormatExample(string msg)
        {
            Person p = new Person();
            Console.WriteLine("Basics - {0}\n\t{1}\n", msg, p.ToString());
            GetBestDevs("Basics - " + msg, "FormatExample", 10);
        }

        public struct Persons
        {
            public int Id;
            public string Name;
            public int Ranq;
        }

        private IEnumerable<Persons>DoGetBestProgrammers()
        {
            IEnumerable<Persons> progs = new List<Persons>()
            {
                new Persons() {  Id = 1, Name = "unu", Ranq = 10 },
                new Persons() {  Id = 2, Name = "doi", Ranq = 14 },
                new Persons() {  Id = 3, Name = "trei", Ranq = 7 },
                new Persons() {  Id = 4, Name = "patru", Ranq = 1 },
                new Persons() {  Id = 5, Name = "cinci", Ranq = 58 },
                new Persons() {  Id = 6, Name = "sase", Ranq = 12 }
            };
            return progs;
        }

        private void GetBestDevs(string msg, string source, int timeout)
        {
            var stopwatch = Stopwatch.StartNew();
            IEnumerable<Persons> devs = DoGetBestProgrammers();
            var message = new StringBuilder()
                .AppendLine(msg)
                .AppendLine($"Got {devs.Count()} smartes devs by {stopwatch.ElapsedMilliseconds} ms.")
                .AppendLine($"Source: {source}")
                .AppendLine($"Timeout: {timeout} ms")
                .AppendLine($"First top 3 devs: {string.Join(", ", devs.Where(x => x.Ranq > 7).Select(x => x.Name))}")
                .AppendLine($"Sum (Ranq): {devs.Sum(t => t.Ranq)}");

            Console.WriteLine(message);
            stopwatch.Stop();
        }
    }

    internal class Person
    {
        private int Id { get; set; } = 60;
        private string Name { get; set; } = "Gigi";
        private double Salary { get; set; } = 50000.00;

        public override string ToString()
        {
            return $"ID: {Id} - Name: {Name}, {Salary}";
        }
    }
}
