using System;
namespace BasicCoreProblem
{
    class Program
    {
        /// <summary>
        /// Swap two number.
        /// </summary>
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine("Before swap a= " + a + "b= " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After swap a= " + a + "b= " + b);


        }
    }
}