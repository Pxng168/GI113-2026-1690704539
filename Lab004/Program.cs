/*
 * Student ID : 1690704539
 * Name       : Lab004
 * Section    : 129D
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum); /* classOk จะเก็บค่า true/false ส่วน classNum เก็บค่าที่เราใส่มา */
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.Write("How many potions? ");
            bool quantityOk = int.TryParse(Console.ReadLine(), out int quantity);
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine($"Name your character: Choose a class (1-3): Starting luck (0.0-10.0): {charName} the Class-{classOk} adventurer enters the dungeon. Luck: {luckOk}");
            Console.WriteLine();
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|           ITEM SHOP           |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine($"How many potions? Valid input: {quantityOk}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine();
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME           |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine($"Set music volume (0.0-1.0): Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");
            Console.WriteLine();
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine($"Enter save name: Choose save slot (1-3): Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");
            Console.WriteLine();
        }
    }
}
