using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_In_Order
{
    // Challenge description:

    // A handful of words have their letters in alphabetical order, that is nowhere in the word do you change direction in the
    // word if you were to scan along the English alphabet. An example is the word "almost", which has its letters in
    // alphabetical order.
    // Your challenge today is to write a program that can determine if the letters in a word are in alphabetical order.


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word to determine if letters are in alphabetical order: ");
            string input = Console.ReadLine();
            bool outOfOrder = false;

            while (true)
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        outOfOrder = true; 
                    }
                }
                break;
            }

            if (!outOfOrder)
            {
                Console.WriteLine($"\nYour word \"{input}\" is in alphabetical order!\n");
            }
            else
            {
                Console.WriteLine($"\nYour word \"{input}\" is not in alphabetical order.\n");
            }
        }
    }
}
