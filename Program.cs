using System;
namespace BasicCoreProblem
{
    class Program
    {
        /// <summary>
        /// check entered value is a leap year or not.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year in four digit number");
            int LeapYear = Convert.ToInt32(Console.ReadLine());
            if (LeapYear <= 9999)
            {
                if (((LeapYear % 4 == 0) && (LeapYear % 100 != 0)) || (LeapYear % 400 == 0))
                {
                    Console.WriteLine("{0} is a Leap Year.", LeapYear);
                }
                else
                {
                    Console.WriteLine("{0} is not a Leapyear.", LeapYear);
                }
            }
            else
            {
                Console.WriteLine("Not valid number \"Ensure four digit number\"");
            }

        }
    }
}