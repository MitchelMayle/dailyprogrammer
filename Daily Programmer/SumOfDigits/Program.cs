using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumOfDigits;

namespace SumOfDigits
{
    class Program
    {
        // adds all digits of given long number and returns sum.
        // original challenge is to return single digit answer -
            // if the sum of digits is 23, it should then add 2 + 3 and return the answer as 5

        static void Main(string[] args)
        {
            long x = 11111;

            Console.WriteLine($" The sum of the digits of {x} is {DigitalRoot.AddDigits(x)}");
        }
    }
}
