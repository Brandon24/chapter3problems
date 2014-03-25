using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n;
            string input;

            while (true)
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();

                n = Convert.ToInt32(input);
                if (input == "999")
                {
                    break;
                }
                if (n < 999)
                {
                    sum += n;
                }
                Console.WriteLine("The Sum is {0}", sum);
            }
         }
      }
}
           