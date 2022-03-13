using System;
namespace BasicCoreProblem
{
    class Program
    {
        /// <summary>
        /// Check Number is Even or Odd.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number ");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number%2 ==0)
            {
                Console.WriteLine("Number is Even Number : {0}",+Number);
            }
            else
            {
                Console.WriteLine("Number is Odd Number : {0}", +Number);
            }
           
        }
       
    }
}