using System;

namespace LineComparison
{
    class Program
    {
        public static void CompareTo()//method to which line is greater
        {
            Console.WriteLine("Please Enter the Values of X1,X2,Y1,Y2 of the First Line");
            double x1 = Console.Read();//User input Length
            double x2 = Console.Read();
            double y1 = Console.Read();
            double y2 = Console.Read();
            double LengthofX = (x2 - x1);//based on the formula for first line
            double LengthofY = (y2 - y1);//based on the formula for first line
            double PowX = Math.Pow(LengthofX, 2);//calculting the power (X2-X1)^2. for first line
            double PowY = Math.Pow(LengthofY, 2);//calculting the power (Y2-Y1)^2. for first line
            double LengthSq = PowX + PowY;//(X2-X1)^2 - (Y2-Y1)^2. for first line
            double LengthofLine = Math.Sqrt(LengthSq);//calculating sqare root. for first line
            Console.WriteLine("Lengthof Line"+ LengthofLine);
            Console.WriteLine("Please Enter the Values of X1,X2,Y1,Y2 of the Second Line");
            double x12 = Console.Read();
            double x22 = Console.Read();
            double y12 = Console.Read();
            double y22 = Console.Read();
            double LengthofX2 = (x22 - x12);//based on the formula for second line
            double LengthofY2 = (y22 - y12);//based on the formula for second line
            double PowX2 = Math.Pow(LengthofX2, 2);//calculting the power (X2-X1)^2. for second line
            double PowY2 = Math.Pow(LengthofY2, 2);//calculting the power (X2-X1)^2. for second line
            double LengthSq2 = PowX2 + PowY2;//(X2-X1)^2 - (Y2-Y1)^2. for second line
            double LengthofLine2 = Math.Sqrt(LengthSq2);//calculating sqare root. for second line
            Console.WriteLine("Lengthof Line" + LengthofLine2);
            if (LengthofLine<LengthofLine2)
            {
                Console.WriteLine("First Line is Smaller");
            }
            else if (LengthofLine > LengthofLine2)
            {
                Console.WriteLine("Second Line is Smaller");
            }
            else
                Console.WriteLine("Both the Lines are Equal");
        }
        static void Main(string [] args)//main method
        {
            Program.CompareTo();//creating object of the class.
        }
    }
}
