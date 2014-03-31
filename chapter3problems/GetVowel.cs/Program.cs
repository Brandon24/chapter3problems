using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowel.cs
{
    class Program
    {
        static void Main(string[] args) 
        {
            while (true)
            { 
                string input;
                Console.WriteLine("Enter a vowel");
                input = Console.ReadLine().ToLower();
                if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
                {
                    Console.WriteLine("Enter another");
                }
                else if (input != "a" || input != "e" || input != "i" || input != "o" || input != "u")
        }
    }
}
