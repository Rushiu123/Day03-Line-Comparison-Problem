namespace Day03_LineComparisonProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem!");
            //Length of Line - UC1
            Console.WriteLine("Enter X1 co-ordinate : ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y1 co-ordinate : ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X2 co-ordinate : ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y2 co-ordinate : ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double lengthOfFirstLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of 1st Line is : " + lengthOfFirstLine);
            Console.WriteLine("Enter X3 co-ordinate : ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y3 co-ordinate : ");
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X4 co-ordinate : ");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y4 co-ordinate : ");
            double y4 = Convert.ToDouble(Console.ReadLine());
            double lengthOfSecondLine = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));

            Console.WriteLine("Length of 2nd Line is : " + lengthOfSecondLine);
            //UC2 & UC3
            if (lengthOfFirstLine == lengthOfSecondLine)
                //UC4 - CompareTo Method
                int returnVal = lengthOfFirstLine.CompareTo(lengthOfSecondLine);
            Console.WriteLine(returnVal);
            //UC2 - Line Equality
            if (returnVal == 0)
            {
                Console.WriteLine("Lines are Equal");
            }
            else if (lengthOfFirstLine >= lengthOfSecondLine)
            //UC3 - Line Comparision
            else if (returnVal > 0)
            {
              Console.WriteLine("1st Line is greater than 2nd Line");
              Console.WriteLine("Line 1 is greater than Line 2");
            }
             else
             {
               Console.WriteLine("1st Line is smaller than 2nd Line");
               Console.WriteLine("Line 1 is smaller than Line 2");
             }

        }
    }
}
     


