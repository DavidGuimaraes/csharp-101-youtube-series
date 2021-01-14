using System;

namespace CSharp101YouTubeSeries
{
    public class Numbers
    {
        public static void Main(string[] args)
        {
            // int a = 10, b = 5, c = a + b;
            // int a = 10;
            // int b = 5;
            // int c = a + b;
            // int d = a - b;
            // int e = a * b;
            // int f = a / b;
            // int g = a % b;
            //
            // Console.WriteLine(c);    //15
            // Console.WriteLine(d);    //5
            // Console.WriteLine(e);    //50
            // Console.WriteLine(f);    //2
            // Console.WriteLine(g);    //0
            
            int a = 10;
            int b = 5;
            int c = 2;
            int d = a + b * c;
            int e = (a + b) * c;
            
            Console.WriteLine(d);    //20
            Console.WriteLine(e);    //30
        }
    }
}