using System;
using System.Collections.Generic;

namespace INSIGHT
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 100; i++)
            {
                int centsRemaining = i;

                List<Coin> coins = new List<Coin>();
                coins.Add(new Coin(25, "Q"));
                coins.Add(new Coin(10, "D"));
                coins.Add(new Coin(5, "N"));
                coins.Add(new Coin(1, "P"));

                foreach (Coin coin in coins)
                {
                    centsRemaining = coin.CalculateCount(centsRemaining);
                    Console.Write(coin.PrintCount() + "\t");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
