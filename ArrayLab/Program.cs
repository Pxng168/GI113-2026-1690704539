using System.Diagnostics;

namespace ArrayLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Aom", "Ben", "Cat", "Dan", "Eve", "Fon" };
            int[] scores = { 5, 7, 9, 1, 2, 6 };

            Console.WriteLine(scores[0]);
            Console.WriteLine(scores[2]);
            Console.WriteLine(scores[1]);
            Console.WriteLine(scores.Length);
            Console.WriteLine(name.Length);
        }
    }
}
