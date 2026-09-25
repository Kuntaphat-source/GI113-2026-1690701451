/*
* Student ID : 1690701451
* Name       : Lab02
* Section    : 129B
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Honkai Mugen Train ===");
            Console.WriteLine("=== Monster Encounter ===");
            Console.WriteLine();

            int MilioHp = 100;
            int monsterHp = 100;

            Console.WriteLine("Milio HP: " + MilioHp);
            Console.WriteLine("Monster HP: " + monsterHp);
            Console.WriteLine();

            Console.WriteLine("Choose your action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            Console.WriteLine("3. Defense");
            Console.WriteLine("4. Escape");
            Console.WriteLine();

            Console.Write("Enter your choice: ");
            bool choiceOk = int.TryParse(Console.ReadLine(), out int choice);

            if (!choiceOk)
            {
                Console.WriteLine("Invalid choice.Please choose 1 2 3 4");
            }
            else if (choice == 1)
            {
                monsterHp -= 30;

                Console.WriteLine("You attack the monster and deal 30 damage.");
                Console.WriteLine("Monster HP is now " + monsterHp + ".");
            }
            else if (choice == 2)
            {
                MilioHp += 20;

                Console.WriteLine("You use a Potion and heals 20 HP.");
                Console.WriteLine("Milio HP is now " + MilioHp + ".");
            }
            else if (choice == 3)
            {
                Console.WriteLine("reduce the damage 40% from the monster's next attack.");
            }
            else if (choice == 4)
            {
                Console.WriteLine("You escape from the monster.");
            }
            else
            {
                Console.WriteLine("Invalid choice.Please choose 1 2 3 4");
            }
        }
    }
}
