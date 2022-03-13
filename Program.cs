using System;
namespace BasicCoreProblem
{
    class Program
    {
        /// <summary>
        /// To check Alphabets enter by user is Vowel or Consonant.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character");

            string value = Console.ReadLine();
            char alphabet = Convert.ToChar(value.ToLower());

            switch (alphabet)
            {
                case 'a':
                    Console.WriteLine("Input Character is vowel");
                    break;
                case 'e':
                    Console.WriteLine("Input Character is vowel");
                    break;
                case 'i':
                    Console.WriteLine("Input Character is vowel");
                    break;
                case 'o':
                    Console.WriteLine("Input Character is vowel");
                    break;
                case 'u':
                    Console.WriteLine("Input Character is vowel");
                    break;

                default:
                    Console.WriteLine("Input Charcter is consonant");
                    break;
            }
        }
    }
}