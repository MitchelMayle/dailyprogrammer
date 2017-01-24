using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Threes
{
    //Challenge description:

    //The input is a single number: the number at which the game starts. Write a program that plays the Threes game, and outputs a
    //valid sequence of steps you need to take to get to 1. Each step should be output as the number you start at, followed by
    // -1 or 1 (if you are adding/subtracting 1 before dividing), or 0 (if you are just dividing). The last line should be 1.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to begin Game Of Threes: ");

            int input = int.Parse(Console.ReadLine());
            int modCount = 0;
            int stepCount = 0;

            Console.WriteLine();

            while (input != 0)
            {
                int remainder = input % 3;
                

                switch (remainder)
                {
                    case 0:
                        Console.WriteLine($"{input}, modified by 0, already divisible by 3");
                        input /= 3;
                        stepCount++;
                        break;
                    case 1:
                        Console.WriteLine($"{input}, modified by subtracting 1");
                        input--;
                        modCount++;
                        stepCount++;
                        break;
                    case 2:
                        Console.WriteLine($"{input}, modified by adding 1");
                        input++;
                        modCount++;
                        stepCount++;
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"COMPLETE! {modCount} Adjustments were made over the course of {stepCount} total steps.");
        }
    }
}
