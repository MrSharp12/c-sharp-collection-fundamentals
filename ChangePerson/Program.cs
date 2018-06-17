using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Person {Name ="Matt", Age = 38},
                new Person {Name = "Danzig", Age = 58}
            };

            foreach (var person in people)
            {
                person.Age = 20;
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            Console.Read();
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return string.Format("{0}, age={1}", Name, Age);
            }
        }
    }
}
