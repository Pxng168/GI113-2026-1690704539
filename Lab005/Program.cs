/*
 * Student ID : 1690704539
 * Name       : Lab005
 * Section    : 129D
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */
using System.Security.Cryptography;

namespace Lab005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //game name / sub
            Console.WriteLine("My Game");
            Console.WriteLine("game title...............");

            //Hero input
            Console.Write("Hero HP : ");
            bool Hero1 = int.TryParse(Console.ReadLine(), out int heroHP);
            Console.Write("Hero ATK : ");
            bool Hero2 = int.TryParse(Console.ReadLine(),out int heroATK);
            Console.Write("Hero DEF : ");
            bool Hero3 = int.TryParse(Console.ReadLine(), out int heroDEF);

            //monster input
            Console.Write("Monster HP : ");
            bool mon1 = int.TryParse(Console.ReadLine(), out int monHP);
            Console.Write("Monster ATK : ");
            bool mon2 = int.TryParse(Console.ReadLine(), out int monATK);
            Console.Write("Monster DEF : ");
            bool mon3 = int.TryParse(Console.ReadLine(), out int monDEF);

            //input val / output
            bool heroStat = Hero1 && Hero2 && Hero3;
            bool monsterStat = mon1 || mon2 || mon3;
            Console.WriteLine($"\nHero Stat : {heroStat}");
            Console.WriteLine($"Monster Stat : {monsterStat}");

            Console.WriteLine($"\nHERO     HP : {heroHP} ATK : {heroATK} DEF : {heroATK}");
            Console.WriteLine($"Monster  HP : {monHP} ATK : {monATK} DEF : {monDEF}");

            //ดื่มยาก่อนสู้
            int potionHeal = 5;
            heroHP += potionHeal;
            Console.WriteLine($"Hero Drink a potion, heals : {potionHeal} HP. Hero HP {heroHP}");

            //normal attack ATK > DEF ถึงจะตีเข้า
            int normalAT = Math.Max(0, heroATK - monDEF);
            Console.WriteLine($"Hero would deals normal attack : {normalAT}");
            //power attack
            int powerDMG = Math.Max(0, (heroATK *2 ) - monDEF);
            Console.WriteLine($"Hero would deals power attack : {powerDMG}");

            //random
            Random random1 = new Random();
            int criroll = random1.Next(1, 101); // สุ่ม 100% 100 ต้องบวก 1 
            bool iscri = criroll <= 20; // 20% cri
            int cridamage = normalAT + Convert.ToInt32(iscri) * normalAT; //ถ้าอยากได้ x2

            Console.WriteLine($"Crit roll {criroll}. Critical Hit : {iscri}");
            Console.WriteLine($"If critical hit player would deal {cridamage} DMG!!");

        }
    }
}
