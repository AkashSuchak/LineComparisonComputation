using System;

namespace LineComparison
{
    class Program
    {        
       
        static void Main(string[] args)
        {
            //Display Welcome Message
            Console.WriteLine("Welcome to Line Comaprison Computation");

            //call function to set value
            ChildClass objOfChildClass = new ChildClass(5, 6, 7, 5);
            ChildClass objOfChildClass1 = new ChildClass(3, 4, 7, 50);

            double line1 = objOfChildClass.LengthOfLine();
            double line2 = objOfChildClass1.LengthOfLine();

            //Display Length of Lines
            Console.WriteLine(" Length of Line 1 : " + line1 + " \n");
            Console.WriteLine(" Length of Line 2 : " + line2 + " \n");

            //Check Equality
            Console.WriteLine("Length of Lines are Equal : " + line1.Equals(line2));

            //Fuction call to Compare Lines
             ChildClass.Compare(line1, line2);
        }
    }
}
