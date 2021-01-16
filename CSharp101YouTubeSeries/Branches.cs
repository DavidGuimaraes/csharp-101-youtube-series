using System;

namespace CSharp101YouTubeSeries
{
    public class Branches
    {
        public static int Main(string[] args)
        {
            // int a = 5;
            // int b = 6;
            // if (a + b > 10)
            // {
            //     Console.WriteLine("The answer is greater than 10.");
            // }
            
            // int c = 5;
            // int d = 3;
            //
            // bool something = c + d > 10;
            
            // if (something)
            //     Console.WriteLine("The answer is greater than 10.");
            // else
            //     Console.WriteLine("The answer is NOT greater than 10.");

            //Additional thing that's not been commented on the tutorial
            // var lambda = new Action(() => Console.WriteLine("The answer is greater than 10."));
            // var lambda2 = new Action(() => Console.WriteLine("The answer is NOT greater than 10."));
            //
            // var action = something ? lambda : lambda2;
            //
            // action();

            int a = 5;
            int b = 3;
            int c = 4;

            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("Both conditions are true.");
            }
            
            if (
                (a + b + c > 10)
                || 
                (a == b)
                )
            {
                Console.WriteLine("At least one of the conditions is true.");
            }

            return 0;
        }
    }
}