using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_LineComparisonProblem
{
    internal class UC_04
    {
        static void Main(string[] args)
        {

            //Taking user input for line1
            Console.WriteLine("Please enter X1 and Y1 coordinates");
            var X1 = Convert.ToDouble(Console.ReadLine());
            var Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter X2 and Y2 coordinates");
            var X2 = Convert.ToDouble(Console.ReadLine());
            var Y2 = Convert.ToDouble(Console.ReadLine());
            double length1 = length(X1, X2, Y1, Y2);

            //Taking user input for line2 
            Console.WriteLine("Please enter X3 and Y3 coordinates");
            var X3 = Convert.ToDouble(Console.ReadLine());
            var Y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter X4 and Y4 coordinates");
            var X4 = Convert.ToDouble(Console.ReadLine());
            var Y4 = Convert.ToDouble(Console.ReadLine());
            double length2 = length(X3, X4, Y3, Y4);

            //Comparing line and getting output
            Console.WriteLine("The length of Line1 {0}.\n And length of Line2 {1}:", length1, length2);
            Console.WriteLine("The line comparison of Line is :" + length1.CompareTo(length2));
            Console.WriteLine("The Line equality check is:" + length1.Equals(length2));

        }
        //Creating method
        public static double length(double X1, double Y1, double X2, double Y2)
        {
            double temp1 = Math.Pow((X2 - X1), 2);
            double temp2 = Math.Pow((Y2 - Y1), 2);
            double LengthOfFirstLine = Math.Sqrt(temp1 + temp2);

            double temp3 = Math.Pow((X4 - X3), 2);
            double temp4 = Math.Pow((Y4 - Y3), 2);
            double LengthOfSecondLine = Math.Sqrt(temp3 + temp4);
            Console.WriteLine("The length of Line1 {0}. \n And length of Line2 {1}:", LengthOfFirstLine, LengthOfSecondLine);

            if (LengthOfFirstLine == LengthOfSecondLine)
            {
                Console.WriteLine("Lenght of two lines are equal");
            }
            else if (LengthOfFirstLine > LengthOfSecondLine)
            {
                Console.WriteLine("Lenght of line1 is greater than length of line2");
            }
            else
            {
                Console.WriteLine("Length of line1 is smaller than length of line2");
            }
            double LengthOfLine = Math.Sqrt(temp1 + temp2);
            return LengthOfLine;
        }
    }
}

