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
            
            // int a = 10;
            // int b = 5;
            // int c = 2;
            // int d = a + b * c;
            // int e = (a + b) * c;
            //
            // Console.WriteLine(d);    //20
            // Console.WriteLine(e);    //30
            
            // int a = 7;
            // int b = 4;
            // int c = 3;
            // int d = (a + b) / c;
            // int e = (a + b) % c;
            //
            // Console.WriteLine($"quotient: {d}");    //3
            // Console.WriteLine($"remainder: {e}");    //2

            // int min = int.MinValue;
            // int max = int.MaxValue;
            //
            // Console.WriteLine($"The range of integers is {min} to {max}");    //The range of integers is -2147483648 to 2147483647
            //
            // int what = max + 3;
            // Console.WriteLine($"An example of overflow: {what}");    //An example of overflow: -2147483646
            
            // double a = 7;
            // double b = 4;
            // double c = 3;
            // double d = (a + b) / c;
            //
            // Console.WriteLine(d);    //3.6666666666666665
            
            // int a = 7;
            // int b = 4;
            // int c = 3;
            // double d = (a + b) / c;
            //
            // Console.WriteLine(d);    //3
            
            // var a = 7d;
            // var b = 4d;
            // var c = 3d;
            // var d = (a + b) / c;
            //
            // Console.WriteLine(d);    //3.6666666666666665
            
            var min = double.MinValue;
            var max = double.MaxValue;
            
            Console.WriteLine($"The range of double is {min} to {max}");    //The range of integers is -2147483648 to 2147483647
        }
    }
}