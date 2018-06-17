using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAsRefTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x1 = { 5, 10, 15, 20 };
            var x2 = x1;

            int[] x3 = { 5, 10, 15, 20 };


            Console.WriteLine("Ref equals(x1, x2): " + ReferenceEquals(x1, x2));
            Console.WriteLine("*********************");

            Console.WriteLine(string.Format("x1 == x2 is {0}", x1 == x2));
            Console.WriteLine(string.Format("x1 == x3 is {0}", x1 == x3));

            Console.Read();

        }
    }
}
