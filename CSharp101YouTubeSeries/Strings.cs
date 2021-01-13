
using System;

namespace CSharp101YouTubeSeries
{
    public class Strings
    {
        public static void Main(string[] args)
        {
            // string firstFriend = "Scott";
            // string secondFriend = "Kendra";
            //
            // Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            //
            // Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
            // Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");

            // string greeting = "     Hello, World!     ";
            // Console.WriteLine($"[{greeting}]");
            //
            // string trimmedGreeting = greeting.TrimStart();
            // Console.WriteLine($"[{trimmedGreeting}]");
            //
            // trimmedGreeting = greeting.TrimEnd();
            // Console.WriteLine($"[{trimmedGreeting}]");
            //
            // trimmedGreeting = greeting.Trim();
            // Console.WriteLine($"[{trimmedGreeting}]");

            string sayHello = "Hello, World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);
            
            sayHello = sayHello.Replace("Something else", "Greetings");
            Console.WriteLine(sayHello);
            
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());
        }
    }
}