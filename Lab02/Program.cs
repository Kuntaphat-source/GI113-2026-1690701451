/*
* Student ID : 1690701451
* Name       : Lab02
* Section    : 129B
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("====Boss Status: INITIAL====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine($"==== BOSS STATUS: AFTER DAMAGE ====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percentage: {hpPercent}%");

            Console.WriteLine("Name: Kale");
            Console.WriteLine("Rank: S");
            Console.WriteLine("HP: 500 / 500");
            Console.WriteLine("Attack Power: 50");
            Console.WriteLine("Level: 99");
            Console.WriteLine("Luck: 100");
            Console.WriteLine();

            Console.WriteLine("Name: Ignis");
            Console.WriteLine("Rank: A");
            Console.WriteLine("HP: 350 / 350");
            Console.WriteLine("Attack Power: 67");
            Console.WriteLine("Level: 50");
            Console.WriteLine("Luck: 16");
            Console.WriteLine();

            Console.WriteLine("Name: Luna");
            Console.WriteLine("Rank: B");
            Console.WriteLine("HP: 250 / 250");
            Console.WriteLine("Attack Power: 30");
            Console.WriteLine("Level: 30");
            Console.WriteLine("Luck: 14");
            Console.WriteLine();

            Console.WriteLine("Name: Michael");
            Console.WriteLine("Rank: C");
            Console.WriteLine("HP: 110 / 110");
            Console.WriteLine("Attack Power: 10");
            Console.WriteLine("Level: 5");
            Console.WriteLine("Luck: 30");
            Console.WriteLine();
        }
    }
}