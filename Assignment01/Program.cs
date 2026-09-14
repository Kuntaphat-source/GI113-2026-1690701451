namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Bloodborne";

            var hunterName = "Hunter";
            var hunterOrigin = "Waste of Skin";
            var hunterRank = 'B';

            int level = 46;
            int health = 200;
            int strength = 20;
            int bloodEchoes = 1000;

            float bloodtinge = 5.0f;
            double insight = 20.674523;

            bool isNightmare = true;

            Console.WriteLine($"*************** {GameTitle} ***************");
            Console.WriteLine($"           HUNTER'S STATS");
            Console.WriteLine($"********************************************");

            Console.WriteLine($"Hunter        : {hunterName}");
            Console.WriteLine($"Origin        : {hunterOrigin}");
            Console.WriteLine($"Hunter Grade  : {hunterRank}");

            Console.WriteLine();
            Console.WriteLine($"Level         : {level}");
            Console.WriteLine($"Health        : {health}");
            Console.WriteLine($"Strength      : {strength}");
            Console.WriteLine($"Bloodtinge    : {bloodtinge}");
            Console.WriteLine($"Insight       : {insight}");
            Console.WriteLine($"Blood Echoes  : {bloodEchoes}");

            Console.WriteLine();
            Console.WriteLine($"Nightmare    : {isNightmare}");

            double levelValue = level;
            Console.WriteLine($"Level stored as double : {levelValue}");

            int insightByCast = (int)insight;
            int insightByConvert = Convert.ToInt32(insight);

            Console.WriteLine($"Insight using cast     : {insightByCast}");
            Console.WriteLine($"Insight using Convert  : {insightByConvert}");

            Console.WriteLine($"********************************************");
        }
    }
}