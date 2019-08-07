using System;

namespace PartyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double coins = 0;


            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    partySize = partySize - 2;
                }

                if (i % 15 == 0)
                {
                    partySize = partySize + 5;
                }

                coins += 50;
                coins = coins - (partySize * 2);

                if (i % 3 == 0)
                {
                    coins = coins - (partySize * 3);
                }

                if (i % 5 == 0)
                {
                    coins += 20 * partySize;
                    if (i % 3 == 0)
                    {
                        coins = coins - (partySize * 2);
                    }
                }
            }

            double coinsEach = 0;
            if (coins > partySize)
            {
                coinsEach = Math.Floor(coins / partySize);
            }
            else if (coins < partySize)
            {
                coinsEach = Math.Floor(partySize / coins);
            }

            Console.WriteLine($"{partySize} companions received {coinsEach} coins each.");
        }
    }
}