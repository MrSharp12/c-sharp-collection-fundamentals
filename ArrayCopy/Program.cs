using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] squares = { 5, 10, 15, 20 };

            //int[] copy = new int[4];
            //squares.CopyTo(copy, 0);

            //LINQ copy call
            int[] copy = squares.ToArray();

            foreach (int value in copy)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine(string.Format("squares == copy? {0}", squares == copy));


            Console.Read();
        }
    }
}
