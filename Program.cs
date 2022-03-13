using System;
namespace BasicCoreProblem
{
    class Program
    {
        /// <summary>
        /// Power of 2 and check it is Leap year or not.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Power value N");
            int N = Convert.ToInt32(Console.ReadLine());
            int i;
            int power2 = 2;

            if (N <= 31)
            {
                for (i = 0; i <= N; i++)
                {
                    Console.WriteLine("{0}^{1}= {2}", power2, i, (Math.Pow(power2, i)));
                    double LeapYear = Math.Pow(power2, i);

                    if (((LeapYear % 4 == 0) && (LeapYear % 100 != 0)) || (LeapYear % 400 == 0))
                    {
                        Console.WriteLine("{0} is a Leap Year.", LeapYear);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a Leapyear.", LeapYear);
                    }
                }
            }
            else
            {
                Console.WriteLine("enter valid number");
            }

        }
    }
}