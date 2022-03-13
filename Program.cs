using System;
namespace BasicCoreProblem
{
    class Program
    {
        /// <summary>
        /// Harmonic Value of N.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Harmonic value N");
            double nValue = Convert.ToInt32(Console.ReadLine());
            double value1 = HarmonicNumber(nValue);
            Console.WriteLine("The Nth Harmonic value : {0}",+value1);            
        }
        public static double HarmonicNumber(double N)
        {
            double result = 1;
            // Ensure N not equal to zero.
            if (N != 0)
            {               
                for (double i = 1; i < N; i++)
                {
                    result += 1 / i;
                }             
            }
            return result;
        }
    }
}