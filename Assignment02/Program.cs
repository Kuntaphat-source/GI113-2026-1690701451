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
            // 1. ประกาศค่าคงที่ (const) รูปแบบ PascalCase
            const string MaterialName = "Iron";
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500.0;

            // 2. แสดงหัวโปรแกรมและเมนู
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("       Welcome to the Forge        ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate:F2} / Salvage {SalvageRate:F2}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            // 3. รับค่า Menu จากผู้ใช้
            Console.Write("=> Choose Menu: ");
            bool isMenuValid = char.TryParse(Console.ReadLine(), out char menu);

            // 4. รับค่า Amount จากผู้ใช้
            Console.Write("=> How much would you like: ");
            bool isAmountValid = double.TryParse(Console.ReadLine(), out double amount);

            // 5. โครงสร้างเงื่อนไขและตรวจสอบ Input Validation
            // ใช้ && ตรวจสอบว่า amount parse ผ่าน และอยู่ช่วง (0, MaxBatch]
            if (isAmountValid && amount > 0 && amount <= MaxBatch)
            {
                // Nested if: ตรวจสอบ menu เมื่อ amount ถูกต้องแล้วเท่านั้น
                // ใช้ || รับทั้งตัวพิมพ์เล็กและตัวพิมพ์ใหญ่ (ห้ามใช้ ToUpper/ToLower)
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