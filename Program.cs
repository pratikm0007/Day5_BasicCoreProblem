using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BasicCoreProblem
{
    class Program
    {
        /// <summary>
        /// Prime Factorisation.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number: ");
            int N;
            int i;
            N = int.Parse(Console.ReadLine());
            if (N % 2 != 0)
            {
                for (i = 1; i*i <= N; i++)
                {
                    if (N % i == 0)
                    {

                        Console.WriteLine(i + " is a Prime factors of " + N);
                    }
                }
            }
            else if (N % 3 != 0)
            {
                for (i = 1; i*i <= N; i++)
                {
                    if (N % i == 0)
                    {

                        Console.WriteLine(i + " is a Prime factors of " + N);
                    }
                }
            }
            else if (N % 5 != 0)
            {
                for (i = 1; i*i <= N; i++)
                {
                    if (N % i == 0)
                    {

                        Console.WriteLine(i + " is a Prime factors of " + N);
                    }
                }
            }

        }
       
    }
}