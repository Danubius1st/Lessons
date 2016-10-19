using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqExpressions
{
    public class LinqClass
    {
        internal struct phoneNo
        {
            internal IEnumerable<string> No;
        }

        internal struct Person
        {
            internal string Name;
            internal int Age;
            internal string Sex;
            internal double Salary;
            internal string Job;
            internal IEnumerable<phoneNo> PhoneNo;
        }

        private IEnumerable<Person> TableSimulation()
        {
            return new List<Person>()
            {
                new Person() {  Name = "George", Age = 10, Sex = "M" },
                new Person() {  Name = "Jim", Age = 20, Sex = "M" },
                new Person() {  Name = "Tim", Age = 15, Sex = "M" },
                new Person() {  Name = "Rachel", Age = 18, Sex = "F" },
                new Person() {  Name = "Anne", Age = 20, Sex = "F" }
            };
        }

        void DisplayPersons(IEnumerable<Person> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine("{0}", person.Name);
            }
        }

        public LinqClass(string msg)
        {
            IEnumerable<Person> personList = TableSimulation();

            Console.WriteLine(msg);
            DisplayPersons(personList);
        }
    }
}
