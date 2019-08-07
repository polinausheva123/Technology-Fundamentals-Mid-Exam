using System;
using System.Collections.Generic;
using System.Linq;

namespace Dungeonest Dark
{
    class Program
{
    static void Main(string[] args)
    {
        int health = 100;
        int treasure = 0;

        string[] dungeons = Console.ReadLine().Split("|").ToArray();


        for (int i = 0; i < dungeons.Length; i++)
        {

            string[] tokens = dungeons[i].Split().ToArray();

            if (tokens[0] == "potion")
            {
                int hp = int.Parse(tokens[1]);
                if (health + hp > 100)
                {

                    Console.WriteLine($"You healed for {100 - health} hp.");
                    Console.WriteLine($"Current health: 100 hp.");
                    health = 100;
                }
                else if (health + hp <= 100)
                {
                    Console.WriteLine($"You healed for {hp} hp.");
                    Console.WriteLine($"Current health: {health + hp} hp.");
                    health += hp;
                }
            }
            if (tokens[0] == "chest")
            {
                int coins = int.Parse(tokens[1]);
                treasure += coins;
                Console.WriteLine($"You found {coins} coins.");
            }
            if (tokens[0] != "potion" && tokens[0] != "chest")
            {
                int monsterAttack = int.Parse(tokens[1]);
                health -= monsterAttack;
                if (health > 0)
                {

                    Console.WriteLine($"You slayed {tokens[0]}.");
                }
                if (health <= 0)
                {

                    Console.WriteLine($"You died! Killed by {tokens[0]}.");
                    Console.WriteLine($"Best room: {i + 1}");
                    break;

                }
            }

        }

        if (health > 0)
        {
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {treasure}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
}