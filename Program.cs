using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: " + Math.Ceiling(15.3));    //rounds up to the nearest integer
            Console.WriteLine("Floor: "+ Math.Floor(15.3));         //Rounds down

            //Max and Min
            int num1 = 13;
            int num2 = 9;
            Console.WriteLine("Lower of num1 {0} and num2 {1} is {2}", num1, num2, Math.Min(num1, num2));
            Console.WriteLine("Greater of num1 {0} and num2 {1} is {2}", num1, num2, Math.Max(num1, num2));

            //Exponents
            Console.WriteLine("3 to the power of 5 is " + Math.Pow(3,5));
            //Pi
            Console.WriteLine("PI is: "+Math.PI);   //PI to the precision of a double

            //SQuare root
            Console.WriteLine("The Square root of 25 is {0}", Math.Sqrt(25.0));

            //Absolute Value
            Console.WriteLine("Absolute value of -30 is {0}", Math.Abs(-30));

            //sinusoids
            Console.WriteLine("Cos of 1 is: " + Math.Cos(1));





            Console.ReadKey();
        }
    }
}
