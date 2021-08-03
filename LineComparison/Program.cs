using System;

namespace LineComparison
{
    class Program
    {
        public double LengthOfLine(int x1, int y1, int x2, int y2)
        {
            //Operation
            double point1 = (x2 - x1);
            double point2 = (y2 - y1);
            double lengthOfLine = Math.Sqrt(Math.Pow(point1, 2) + Math.Pow(point2, 2));

            return lengthOfLine;
        }
        
        static void Main(string[] args)
        {
            //Display Welcome Message
            Console.WriteLine("Welcome to Line Comaprison Computation");

            //Object of a class
            Program lengthOfLine = new Program();
            
            //call function to set value
            double line1 = lengthOfLine.LengthOfLine(5, 6, 7, 5);
            double line2 = lengthOfLine.LengthOfLine(2, 8, 6, 12);

            //Display Length of Lines
            Console.WriteLine(" Length of Line 1 : " + line1 + " \n");
            Console.WriteLine(" Length of Line 2 : " + line2 + " \n");

            //Check Equality
            Console.WriteLine("Length of Lines are Equal : " + line1.Equals(line2));
        }
    }
}
