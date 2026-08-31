namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Maxlevel = 10;

            var bossName = "Kirin"; //ต้องประกอบด้วย var ห้ามเขียน string ตรงๆ
            var rank = "S";         // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            var level = 7;
            var maxHp = 240;
            int currentHp = 115;    // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackpower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // Boss Stats
            Console.WriteLine("===== KIRIN SAVE CONVERTER ===== ");
            Console.WriteLine($"NAME: {bossName}" +
                $"\nRANK: {rank}" +
                $"\nLEVEL: {level} / {Maxlevel}" +
                $"\nHP: {currentHp} / {maxHp}" +
                $"\nATTACK POWER: {attackpower}" +
                $"\nCRIT MULTIPLIER: {critMultiplier}" +
                $"\nIS BOSS: {isBoss}");

            //imprint conversation HP (int) --> double
            Console.WriteLine("\n----- IMplicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}");

            //Calculate Percent as double
            Console.WriteLine("\n----- Exact HP Percent (no interger truncation) -----");
            double hpPercentExact = currentHpDouble = 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");

            //Explicit casting attackPower (float) --> int

            //Cast vs. Convert: Crit Multiplier
        }
    }
}
