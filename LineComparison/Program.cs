using System;

namespace LineComparison
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Values of X1,X2,Y1,Y2 of the First Line");
            double x1 = Console.Read();
            double x2 = Console.Read();
            double y1 = Console.Read();
            double y2 = Console.Read();
            double LengthofX = (x2 - x1);
            double LengthofY = (y2 - y1);
            double PowX = Math.Pow(LengthofX, 2);
            double PowY = Math.Pow(LengthofY, 2);
            double LengthSq = PowX + PowY;
            double LengthofLine = Math.Sqrt(LengthSq);
            Console.WriteLine("Lengthof Line"+ LengthofLine);
            Console.WriteLine("Please Enter the Values of X1,X2,Y1,Y2 of the Second Line");
            double x12 = Console.Read();
            double x22 = Console.Read();
            double y12 = Console.Read();
            double y22 = Console.Read();
            double LengthofX2 = (x22 - x12);
            double LengthofY2 = (y22 - y12);
            double PowX2 = Math.Pow(LengthofX2, 2);
            double PowY2 = Math.Pow(LengthofY2, 2);
            double LengthSq2 = PowX2 + PowY2;
            double LengthofLine2 = Math.Sqrt(LengthSq2);
            Console.WriteLine("Lengthof Line" + LengthofLine2);
            if(LengthofLine==LengthofLine2)
            {
                Console.WriteLine("Both the Lines are Equal");
            }
        }
    }
}
