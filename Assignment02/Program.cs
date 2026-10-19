/*
* Student ID : 1690701451
* Name        : Assignment02
* Section     : 129B
* No.         : N/A
* Course      : GI113 Computer Programming (GI)
*/

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            const string MaterialName = "Iron";
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500.0;

            
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("       Welcome to the Forge        ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate:F2} / Salvage {SalvageRate:F2}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            Console.Write("=> Choose Menu: ");
            bool isMenuValid = char.TryParse(Console.ReadLine(), out char menu);

            Console.Write("=> How much would you like: ");
            bool isAmountValid = double.TryParse(Console.ReadLine(), out double amount);

            if (isAmountValid && amount > 0 && amount <= MaxBatch)
            {
                if (menu == 'S' || menu == 's')
                {
                    double result = amount * SmeltRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {result:F2} {MaterialName} Ingot");
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double result = amount / SalvageRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ingot = {result:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("Error: Invalid menu selection! Please enter 'S' or 'B'.");
                }
            }
            else
            {
                Console.WriteLine($"Error: Invalid amount! Value must be a number between 0.01 and {MaxBatch:F2}.");
            }
        }
    }
}
