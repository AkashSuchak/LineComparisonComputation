using System;

namespace LineComparison
{
    class Program
    {        
        public static void Compare(double line1, double line2)
        {
            //Comaprison assign to Variable
            int linesCompare = (line1.CompareTo(line2));
            
            //Condition to Check Comparison
            if (linesCompare.Equals(0))            
                Console.WriteLine(" Result : Both the lines are having same length or both lines are equal.");            
            else if (linesCompare.Equals(-1))            
                Console.WriteLine(" Result : Length of FirstLine Is lesser Than secondLine");            
            else            
                Console.WriteLine(" Result : Length of FirstLine Is Greater Than secondLine");
            
        }
        static void Main(string[] args)
        {
            //Display Welcome Message
            Console.WriteLine("Welcome to Line Comaprison Computation");

            //call function to set value
            ChildClass objOfChildClass = new ChildClass();
            double line1 = objOfChildClass.LengthOfLine(5, 6, 7, 5);
            double line2 = objOfChildClass.LengthOfLine(2, 8, 1, 12);

            //Display Length of Lines
            Console.WriteLine(" Length of Line 1 : " + line1 + " \n");
            Console.WriteLine(" Length of Line 2 : " + line2 + " \n");

            //Check Equality
            Console.WriteLine("Length of Lines are Equal : " + line1.Equals(line2));

            //Fuction call to Compare Lines
            Compare(line1, line2);
        }
    }
}
