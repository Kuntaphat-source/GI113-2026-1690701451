namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===>> Game Title <<===");
            Console.WriteLine("Hero vs Monster -- Calculate Damage");

            // Hero Stats
            Console.WriteLine("Hero HP: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);

            Console.WriteLine("Hero ATK: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);

            Console.WriteLine("Hero DEF: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Monster Stats
            Console.WriteLine("Monster HP: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);

            Console.WriteLine("Monster ATK: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);

            Console.WriteLine("Monster DEF: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);

            // Check for valid input
            bool heroInputValid = heroHpOk && heroAtkOk && heroDefOk;
            bool monsterInputValid = monHpOk && monAtkOk && monDefOk;

            Console.WriteLine($">> Hero stats Valid: {heroInputValid}");
            Console.WriteLine($">> Monster stats Valid: {monsterInputValid}");

            Console.WriteLine($">> Hero HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($">> Monster HP: {monHp}, ATK: {monAtk}, DEF: {monDef}");

            // Hero drink potion before the fight
            int potionheal = 14;
            heroHp += potionheal;

            Console.WriteLine($"\nHero drink potion heal {potionheal} HP, Hero HP is: {heroHp}");

            // Damage calculation
            int normalDamage = Math.Max(0, heroAtk - monDef);
            Console.WriteLine($"Normal Attack Damage: {normalDamage} DMG");

            int powerDamage = Math.Max(0, (heroAtk * 2) - monDef);
            Console.WriteLine($"Power Attack Damage: {powerDamage} DMG");

            int counterDamage = Math.Max(0, (monAtk - heroDef) / 2);
            Console.WriteLine($"Counter Attack Deals: {counterDamage} DMG");

            // Critical hit
            Random randomSomething = new Random();

            int roll = randomSomething.Next(1, 101);
            bool isCrit = roll <= 20;

            int critDamage = normalDamage
            + Convert.ToInt32(isCrit) * normalDamage;

            Console.WriteLine($"Crit Damage roll: {roll}, (Crit?: {isCrit})");
            Console.WriteLine($"If critical, normal attack would deal: {critDamage} DMG");
        }
    }
}