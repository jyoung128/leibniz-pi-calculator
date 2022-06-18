/* Jonah Young
 * Leibniz Pi Calculator
 * 9/27/2020
 */

using System;

namespace LeibnizPiCalculatorJonahY
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 0;
            int userNumber;

            Console.WriteLine("Jonah's Leibniz Pi Calculator");
            Console.WriteLine("");

            do
            {
                Console.Write("Please enter a number > 1,000,000: ");
                String userInput = Console.ReadLine();
                Int32.TryParse(userInput, out userNumber);

            } while (userNumber < 1000001);

            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            for (int i = 0; i < userNumber; i++) { 
        
                pi = pi + (Math.Pow(-1, i) / (2 * i + 1));

                String formattedIteration = String.Format("{0:n0}", i + 1);

                switch (i)
                {
                    case 9:
                        Console.WriteLine($"At {formattedIteration} iterations, the value of Pi is {pi * 4}");
                        break;
                    case 999:
                        Console.WriteLine($"At {formattedIteration} iterations, the value of Pi is {pi * 4}");
                        break;
                    case 99999:
                        Console.WriteLine($"At {formattedIteration} iterations, the value of Pi is {pi * 4}");
                        break;
                    case 499999:
                        Console.WriteLine($"At {formattedIteration} iterations, the value of Pi is {pi * 4}");
                        break;
                    case 999999:
                        Console.WriteLine($"At {formattedIteration} iterations, the value of Pi is {pi * 4}");
                        break;


                }

            }

            String formattedUserNumber = String.Format("{0:n0}", userNumber);
            Console.WriteLine($"At {formattedUserNumber} iterations, the value of Pi is {pi * 4}");

        }
    }
}
