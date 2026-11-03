/*
 * Student ID : 1690704539
 * Name       : Lab11
 * Section    : 129D
 * No.        : 
 * Course     : GI113 Computer Programming (GI)
 */
using System;

namespace Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            float average;
            int maximum;
            int minimum;
            int[] numbers = { -5, -2, -9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Number " + (i + 1) + ": " + numbers[i]);
            }

            sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            average = (float)sum / numbers.Length;
            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Average : " + average);

            maximum = numbers[0];
            minimum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }
                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }
            Console.WriteLine("Maximum : " + maximum);
            Console.WriteLine("Minimum : " + minimum);

            System.Array.Sort(numbers);
            foreach (int n in numbers)
            {
                Console.WriteLine("Sorted : " + n);
            }
        }
    }
}
