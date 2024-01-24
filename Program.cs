using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int n))
            {
                int result = CalculateSum(n);
                if (result != -1)
                {
                    Console.WriteLine($"The sum of numbers from 1 to {n} is: {result}");
                }
                else
                {
                    Console.WriteLine("ERROR: Please enter a positive integer.");
                }

            }
            else
            {
                Console.WriteLine("ERROR: Please enter a valid integer.");
            }
        }
        static int CalculateSum(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        }
    }

