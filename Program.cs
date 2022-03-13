using System;
namespace BasicCoreProblem
{
    class Program
    {
        /// <summary>
        /// Compute Quotient and Remainder
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Divisor value ");
            int Divisor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Dividend value ");
            int Dividend = Convert.ToInt32(Console.ReadLine());

            //To compute Quetient
            int Quotient = Dividend / Divisor;
            Console.WriteLine("Quotient is : {0}", +Quotient);

            //To compute Remainder
            int Remainder = Dividend % Divisor;
            Console.WriteLine("Remainder is : {0}", +Remainder);
        }
       
    }
}