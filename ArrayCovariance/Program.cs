using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCovariance
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] objArr = new object[3];
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

            //array covariance
            //implicitly casting derived[] to base[]
            //CAREFUL, it will turn a compile time error to a run time error
            //object[] objArr2 = daysOfWeek;

            //objArr[0] = 3;
            //Console.WriteLine("objArr[0] = " + objArr[0]);

            //object[] objArr2 = daysOfWeek;
            //objArr2[0] = 3;
            //Console.WriteLine("objArr2[0] = " + objArr2[0]);


            //foreach (object obj in objArr2)
            //{
            //    Console.WriteLine(obj);
            //}

            Console.Read();
        }
    }
}
