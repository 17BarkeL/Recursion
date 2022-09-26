using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5! means 5 x 4 x 3 x 2 x 1

            Console.WriteLine("Factorial Factory\n-----------------");

            int n = 0;

            // Get the user to enter an integer for n
            Console.Write("Enter a number: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Enter a number: ");
            }


            Console.ReadLine();
        }

        /*static int Factorial(int number)
        {
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }*/
    }
}
