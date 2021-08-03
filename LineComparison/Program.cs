using System;

namespace LineComparison
{
    class Program
    {
        public void LengthOfLine(int x1, int y1, int x2, int y2)
        {
            //Operation
            double point1 = (x2 - x1);
            double point2 = (y2 - y1);
            double lengthOfLine = Math.Sqrt(Math.Pow(point1, 2) + Math.Pow(point2, 2));

            //Display
            Console.WriteLine(" Line Point 1 : " + point1 + " \n");
            Console.WriteLine(" Line Point 2 : " + point2 + " \n");
            Console.WriteLine(" Length of Line : " + lengthOfLine + " \n");
        }
        
        static void Main(string[] args)
        {
            //Display Welcome Message
            Console.WriteLine("Welcome to Line Comaprison Computation");

            //Object of a class
            Program lengthOfLine = new Program();
            //call function to set value
            lengthOfLine.LengthOfLine(5, 6, 7, 5);
            
        }
    }
}
