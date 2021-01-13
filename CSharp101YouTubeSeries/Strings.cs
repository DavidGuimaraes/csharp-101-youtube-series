
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

            // string sayHello = "Hello, World!";
            // Console.WriteLine(sayHello);
            // sayHello = sayHello.Replace("Hello", "Greetings");
            // Console.WriteLine(sayHello);
            //
            // sayHello = sayHello.Replace("Something else", "Greetings");
            // Console.WriteLine(sayHello);
            //
            // Console.WriteLine(sayHello.ToUpper());
            // Console.WriteLine(sayHello.ToLower());

            // string songLyrics = "You say goodbye, and I say hello";
            //
            // Console.WriteLine(songLyrics.Contains("goodbye"));
            // Console.WriteLine(songLyrics.Contains("greetings"));
            //
            // string newSongLyrics = "You say greetings, and I say hello";
            //
            // Console.WriteLine(newSongLyrics.Contains("goodbye"));
            // Console.WriteLine(newSongLyrics.Contains("greetings"));
            
            string songLyrics = "You say goodbye, and I say hello";
            
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.EndsWith("hello"));
            
            Console.WriteLine(songLyrics.StartsWith("you"));
            Console.WriteLine(songLyrics.EndsWith("hello"));

            var firstSubString = "You";
            var secondSubString = "HELLO";
            Console.WriteLine(songLyrics.StartsWith(firstSubString.ToLower()));
            Console.WriteLine(songLyrics.EndsWith(secondSubString.ToLower()));
        }
    }
}