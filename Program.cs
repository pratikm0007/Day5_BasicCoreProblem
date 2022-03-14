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
        /// Find the largest among three number.
        /// </summary>
        static void Main(string[] args)
        {
            int a = 71;
            int b = 150;
            int c = 30;

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a is gretest among all three number");
                }
            }
            else if (b > c)
            {
                if (b > a )
                {
                    Console.WriteLine("b is gretest among all three number");
                }
            }
            else
            {
                Console.WriteLine("c is gretest among all three number");
            }
        }
       
    }
}