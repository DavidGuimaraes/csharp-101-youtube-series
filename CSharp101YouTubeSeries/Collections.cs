using System;
using System.Collections.Generic;

namespace CSharp101YouTubeSeries
{
    public class Collections
    {

        private static List<int> _fibonacciSequence { get; set; }
        private static int _previous;
        private static int _previous2;
        
        public static void Main(string[] args)
        {
            // var names = new List<string> {"<name>", "David", "Amanda" };
        //     foreach (var name in names)
        //     {
        //         Console.WriteLine($"Hello, {name}!");
        //     }
        //
        //     for (int i = 0; i <= names.Count-1; i++) {
        //         Console.WriteLine($"Hello, {names[i]}!");
        //     }
        //
        //     List<string> newNames = new List<string>();
        //     newNames.Add("Nessa");
        //     newNames.Add("Téia");
        //
        //     foreach (var newName in newNames)
        //     {
        //         Console.WriteLine(newName);
        //     }
        //
        //     names.Remove("<name>");
        //     foreach (var name in names)
        //     {
        //         Console.WriteLine(name);
        //     }
        //
        //     names.ForEach(name => Console.WriteLine(name));

            // var name = "David";
            // var index = names.IndexOf(name);
            //
            // if (index == -1)
            //     Console.WriteLine($"{name} was NOT found!");
            // else
            //     Console.WriteLine($"{name} was found at index {index}");
            //
            // names.Sort();
            //
            // names.ForEach(x => Console.WriteLine(x));

            // var fibbonaciNumbers = new List<int> { 1, 1 };

            // var previous = fibbonaciNumbers[fibbonaciNumbers.Count - 1];
            // var previous = fibbonaciNumbers[^1];
            // var previous2 = fibbonaciNumbers[^2];
            //
            // fibbonaciNumbers.Add(previous + previous2);
            //
            // fibbonaciNumbers.ForEach(Console.WriteLine);
            
            Challenge();
        }

        private static void InitializeFibonacciSequence()
        {
            _fibonacciSequence = new List<int> {1, 1};
        }

        private static void Calculate()
        {
            _previous = _fibonacciSequence[^1];
            _previous2 = _fibonacciSequence[^2];
            
            _fibonacciSequence.Add(_previous + _previous2);
        }

        private static void PrintFibonacciNumbers()
        {
            _fibonacciSequence.ForEach(Console.WriteLine);
        }

        private static void Challenge()
        {
            InitializeFibonacciSequence();

            var count = 1;
            while (count <= 18)
            {
                Calculate();
                count++;
            }

            PrintFibonacciNumbers();
        }
    }
}