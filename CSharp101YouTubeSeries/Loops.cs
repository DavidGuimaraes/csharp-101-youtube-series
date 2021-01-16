using System;

namespace CSharp101YouTubeSeries
{
    public class Loops
    {
        public static int Main(string[] args)
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello, World! The counter is {counter}");
                counter++;
            }

            counter = 0;
            do
            {
                Console.WriteLine($"Hello, World! The counter is {counter}");
                counter++;
            } while (counter < 5);

            for (byte i = 0; i < 10; i++)
            {
                Console.WriteLine($"I'm using For Loop! The counter is {i}");
            }
            
            return 0;
        }
    }
}