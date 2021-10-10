using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Values of X1,X2,Y1,Y2");
            double x1 = Console.Read();
            double x2 = Console.Read();
            double y1 = Console.Read();
            double y2 = Console.Read();
            double LengthofX = (x2 - x1);
            double LengthofY = (y2 = y1);
            double PowX = Math.Pow(LengthofX, 2);
            double PowY = Math.Pow(LengthofY, 2);
            double LengthSq = PowX + PowY;
            double LengthofLine = Math.Sqrt(LengthSq);
            Console.WriteLine("Length of Line=" + LengthofLine);
        }
    }
}
