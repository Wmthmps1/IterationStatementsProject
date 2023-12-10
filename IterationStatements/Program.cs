using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            int num = 0;

            
                do
                {
                    num++;
                    numbers.Add(num);
                } while (num < 100) ;



            // Create a while loop
            while (num < 200)
            {
                    num++;
                    numbers.Add(num);

            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            foreach (int value in numbers)
                {
                    Console.WriteLine(value);
                }
             


            Console.WriteLine("");
            Console.WriteLine("Decrease:");

                for (int i = 199; i > 0; i--)
                {
                    Console.WriteLine(numbers[i]);
                }
        }
    }
}
