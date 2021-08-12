using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    //Abstract Class
    abstract class AbstractClass
    {               
        //Abstract Method
        public abstract double LengthOfLine();        
    }

    //Child Class
    class ChildClass : AbstractClass
    {
        //Instance
        public double X1, Y1, X2, Y2;

        //Parameterized Constructor
        public ChildClass(double X1, double Y1, double X2, double Y2)
        {
            SetValues(X1, Y1, X2, Y2);
        }
        public void SetValues(double X1, double Y1, double X2, double Y2)
        {
            SetX1(X1);
            SetY1(Y1);
            SetX2(X2);
            SetY2(Y2);
        }

        //Get Set methods
        public double GetX1()
        {
            return X1;
        }
        public void SetX1(double X1) => this.X1 = X1;

        public double GetY1()
        {
            return Y1;
        }
        public void SetY1(double Y1) => this.Y1 = Y1;

        public double GetX2()
        {
            return X2;
        }
        public void SetX2(double X2) => this.X2 = X2;

        public double GetY2()
        {
            return Y2;
        }
        public void SetY2(double Y2) => this.Y2 = Y2;

        //Calculating Length of Line
        public override double LengthOfLine()
        {            
            //Operation
            double point1 = (X2 - X1);
            double point2 = (Y2 - Y1);
            double lengthOfLine = Math.Sqrt(Math.Pow(point1, 2) + Math.Pow(point2, 2));

            return lengthOfLine;             
        }
        //Comparison of Lines
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
    }
}
