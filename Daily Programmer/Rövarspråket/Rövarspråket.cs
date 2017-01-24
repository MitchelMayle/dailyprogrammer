using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rövarspråket
{
    class Rövarspråket
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word to convert to Rövarspråket: ");
            string input = Console.ReadLine();
            string final = "";

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'A':
                    case 'a':
                    case 'E':
                    case 'e':
                    case 'I':
                    case 'i':
                    case 'O':
                    case 'o':
                    case 'U':
                    case 'u':
                    case 'Y':
                    case 'y':
                        final += input[i];
                        break;
                    default:
                        final += input[i] + "o" + input[i];
                        break;
                }
            }

            Console.WriteLine($"Your word \"{input}\" translates to \"{final}\" in Rövarspråket.");

        }
    }
}
