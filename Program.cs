using System;
namespace BasicCoreProblem
{
    class Program
    {
        /// <summary>
        /// FlipCoin and get percentage of Head and Tail.
        /// </summary>
        static void Main(string[] args)
        {            
            Console.WriteLine("Please enter the value for number of flip");

            int Head = 0;
            int Tail = 0;
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercentage = 0;
            double TailPercentage;

            int CoinFlip = Convert.ToInt32(Console.ReadLine());

            if (CoinFlip > 0)
            {
                for (int i = 0; i < CoinFlip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    if (number == 1)
                    {
                        Head = 1;
                        HeadCount += Head;
                    }
                    else if (number == 0)
                    {
                        Tail = 1;
                        TailCount += Tail;
                    }
                    Console.WriteLine(number);

                }

                Console.WriteLine("------------------------");

                HeadPercentage = HeadCount * 100 / CoinFlip;
                TailPercentage = TailCount * 100 / CoinFlip;

                Console.WriteLine("Head Percentage is :" + HeadPercentage);
                Console.WriteLine("Tail Percentage is :" + TailPercentage);

            }
            else
            {
                Console.WriteLine("Please enter positive number");
            }
            
        }
    }
}