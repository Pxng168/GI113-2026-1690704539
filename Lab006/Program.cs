/*
 * Student ID : 1690704539
 * Name       : Lab006
 * Section    : 129D
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mon = 50;
            string wort1 = "";
            string nameHero = "";
            Console.Write("Enter Number Hero(1-3) : ");
            bool name = int.TryParse(Console.ReadLine(), out int nametotal);
            Console.Write("Enter HP Hero : ");
            bool hp = double.TryParse(Console.ReadLine(), out double hptotal);
            Console.Write("Enter Attack Hero : ");
            bool att = int.TryParse(Console.ReadLine(), out int atttotal);
            Console.Write("Enter Rank Hero(A B C) : ");
            bool rank = char.TryParse(Console.ReadLine(), out char ranktotal);
            string title1 = @$"
███████████████████████████████████████████████████████████████████████████████
▐█   ____            _           _       __  __       _   _                  ▐█
▐█  |  _ \ _ __ ___ (_) ___  ___| |_ _  |  \/  |     | | | | ___ _ __ ___    ▐█
▐█  | |_) | '__/ _ \| |/ _ \/ __| __(_) | |\/| |_____| |_| |/ _ \ '__/ _ \   ▐█
▐█  |  __/| | | (_) | |  __/ (__| |_ _  | |  | |_____|  _  |  __/ | | (_) |  ▐█
▐█  |_|   |_|  \___// |\___|\___|\__(_) |_|  |_|     |_| |_|\___|_|  \___/   ▐█
▐█                 |__/                                                      ▐█
▐█                                                                           ▐█
▐█      Hero{nametotal} is {hptotal}HP {atttotal}Damage Rank : {ranktotal}   ▐█
▐█                                                                           ▐█
▐█                __   _____  _   _  __        _____ _   _                   ▐█
▐█                \ \ / / _ \| | | | \ \      / /_ _| \ | |                  ▐█
▐█                 \ V / | | | | | |  \ \ /\ / / | ||  \| |                  ▐█
▐█                  | || |_| | |_| |   \ V  V /  | || |\  |                  ▐█
▐█                  |_| \___/ \___/     \_/\_/  |___|_| \_|                  ▐█
▐█                                                                           ▐█
███████████████████████████████████████████████████████████████████████████████
";
            string title2 = @$"
███████████████████████████████████████████████████████████████████████████████
▐█   ____            _           _       __  __       _   _                  ▐█
▐█  |  _ \ _ __ ___ (_) ___  ___| |_ _  |  \/  |     | | | | ___ _ __ ___    ▐█
▐█  | |_) | '__/ _ \| |/ _ \/ __| __(_) | |\/| |_____| |_| |/ _ \ '__/ _ \   ▐█
▐█  |  __/| | | (_) | |  __/ (__| |_ _  | |  | |_____|  _  |  __/ | | (_) |  ▐█
▐█  |_|   |_|  \___// |\___|\___|\__(_) |_|  |_|     |_| |_|\___|_|  \___/   ▐█
▐█                 |__/                                                      ▐█
▐█                                                                           ▐█
▐█      Hero{nametotal} is {hptotal}HP {atttotal}Damage Rank : {ranktotal}   ▐█
▐█                                                                           ▐█
▐█                __   _____  _   _   _     ___  ____  _____                 ▐█
▐█                \ \ / / _ \| | | | | |   / _ \/ ___|| ____|                ▐█
▐█                 \ V / | | | | | | | |  | | | \___ \|  _|                  ▐█
▐█                  | || |_| | |_| | | |__| |_| |___) | |___                 ▐█
▐█                  |_| \___/ \___/  |_____\___/|____/|_____|                ▐█
▐█                                                                           ▐█
███████████████████████████████████████████████████████████████████████████████
";
            if (atttotal >= 50)
            {
                wort1 = title1;
            }
            else
            {
                wort1 = title2;
            }
            Console.WriteLine();
            Console.WriteLine(wort1);
        }
    }
}
