using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareInitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1;
            int[] x2;

            int x3 = 5;
            int[] x4 = new int[5];

            //others ways to declare arrays
            //declatration with array initialization
            //REMEMBER, array count is part of its value, so it goes on the right
            //int[] x5 = new int[5] { 5, 10, 15, 20, 25 };
            //removing the int count from the array brackets
            //int[] x5 = new int[] { 5, 10, 15, 20, 25 };
            //using var
            //var x5 = new int[] { 5, 10, 15, 20, 25 };
            //intialization list on its own
            int[] x5 = { 5, 10, 15, 20, 25 };

            int eight = 8;
            int[] squares = new int[]
            {
                1,
                2 * 2,
                eight + 1,
                int.Parse("16"),
                (int)Math.Sqrt(625)
            };
           
           
            
        }
    }
}
