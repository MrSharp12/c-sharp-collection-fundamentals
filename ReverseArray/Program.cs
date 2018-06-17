using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
           {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //works in place, doesn't create new array
            //Array.Reverse(daysOfWeek);

            //foreach (string days in daysOfWeek)
            //{
            //    Console.WriteLine(days);
            //}

            //another way
            //REMEBER, LINQ methods tend to return new objects
            //whereas array methods work in-place
            var reversed = daysOfWeek.Reverse();

            foreach (string days in reversed)
            {
                Console.WriteLine(days);
            }

            Console.Read();
        }
    }
}
