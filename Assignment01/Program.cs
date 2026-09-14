namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Bloodborne";

            var hunterName = "Hunter";
            var origin = "Waste of Skin";

            int Level = 46;
            int hp = 200;
            int strength = 20;
            int bloodEchoes = 1000;

            float bloodtinge = 5.5f;    
            double insight = 20.5;

            var hunterRank = 'B';
            bool isInNightmare = true;

            Console.WriteLine("=================================");
            Console.WriteLine($"        {GameTitle}");
            Console.WriteLine("        HUNTER STAT ");
            Console.WriteLine("=================================");
            Console.WriteLine($"Name        : {hunterName}");
            Console.WriteLine($"Origin      : {origin}");
            Console.WriteLine($"Level       : {Level}");
            Console.WriteLine($"HP          : {hp}");
            Console.WriteLine($"Strength    : {strength}");
            Console.WriteLine($"Blood Echoes: {bloodEchoes}");
            Console.WriteLine($"Bloodtinge  : {bloodtinge}");
            Console.WriteLine($"Insight     : {insight}");
            Console.WriteLine($"Hunter Rank : {hunterRank}");
            Console.WriteLine($"InNightmare  : {isInNightmare}");
            Console.WriteLine();

            Console.WriteLine("=================================");
        }
    }
}