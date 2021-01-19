using System;
using System.Collections.Generic;

namespace CSharp101YouTubeSeries
{
    public class Collections
    {
        public static void Main(string[] args)
        {
            var names = new List<string> {"<name>", "David", "Amanda" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello, {name}!");
            }

            for (int i = 0; i <= names.Count-1; i++) {
                Console.WriteLine($"Hello, {names[i]}!");
            }

            List<string> newNames = new List<string>();
            newNames.Add("Nessa");
            newNames.Add("Téia");

            foreach (var newName in newNames)
            {
                Console.WriteLine(newName);
            }

            names.Remove("<name>");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names.ForEach(name => Console.WriteLine(name));
        }
    }
}