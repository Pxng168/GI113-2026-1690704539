/*
 * Student ID : 1690704539
 * Name       : Lab002
 * Section    : 129D
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            string name1 = "Ping";
            string name2 = "Beam";
            string name3 = "Lisa";
            string name4 = "Sun";
            char rank = 'S';
            int level = 7;
            int power1 = 21;
            int power2 = 19;
            int power3 = 22;
            int power4 = 17;
            int defense1 = 12;
            int defense2 = 13;
            int defense3 = 14;
            int defense4 = 15;
            int age1 = 18;
            int age2 = 19;
            int age3 = 28;
            int age4 = 22;
            int maxHp = 240;
            int currentHp = 175;
            float attack1 = 50.36f;
            float attack2 = 43.56f;
            float attackPower = 42.5f;
            double critMultiplier = 1.475;
            double attack3 = 36.48;
            double attack4 = 63.89;
            bool isBoss = true;
            bool win = true;
            bool defeat = false;


            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name : {bossName}");
            Console.WriteLine($"Rank : {rank}");
            Console.WriteLine($"Level : {level}");
            Console.WriteLine($"Hp : {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power : {attackPower}");
            Console.WriteLine($"Crit Multiplier : 1.75");
            Console.WriteLine($"Is Boss: : {isBoss}");
            Console.WriteLine();
            Console.WriteLine($"HP Percent : {currentHp * 100 / maxHp}");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            currentHp = currentHp - 60;
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: {currentHp * 100 / maxHp}%");

            Console.WriteLine("\n++++++++++++++++PING GAME++++++++++++++++");
            Console.WriteLine("\n=====Boss Hp 20=====");
            Console.WriteLine($"\n--------{name1}--------");
            Console.WriteLine($"Age : {age1}");
            Console.WriteLine($"Attack Power : {attack1}");
            Console.WriteLine($"Power : {power1}");
            Console.WriteLine($"Defeat the boss : {win}");
            Console.WriteLine($"Defense : {defense1}");
            Console.WriteLine($"\n--------{name2}--------");
            Console.WriteLine($"Age : {age2}");
            Console.WriteLine($"Attack Power : {attack2}");
            Console.WriteLine($"Power : {power2}");
            Console.WriteLine($"Defeat the boss : {defeat}");
            Console.WriteLine($"Defense : {defense2}");
            Console.WriteLine($"\n--------{name3}--------");
            Console.WriteLine($"Age : {age3}");
            Console.WriteLine($"Attack Power : {attack3}");
            Console.WriteLine($"Power : {power3}");
            Console.WriteLine($"Defeat the boss : {win}");
            Console.WriteLine($"Defense : {defense3}");
            Console.WriteLine($"\n--------{name4}--------");
            Console.WriteLine($"Age : {age4}");
            Console.WriteLine($"Attack Power : {attack4}");
            Console.WriteLine($"Power : {power4}");
            Console.WriteLine($"Defeat the boss : {defeat}");
            Console.WriteLine($"Defense : {defense4}");
            Console.WriteLine("\n++++++++++++++++END++++++++++++++++");
        }
    }
}
