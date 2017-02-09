using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWithDigits
{
    // You have to search all numbers from inclusive 1 to inclusive a given
    // number x, that have the given digit d in it.
    // The value of d will always be 0 - 9.
    // The value of x will always be greater than 0.

    // You have to return as an array of
    // the count of these numbers,
    // their sum 
    // and their product.

    // x = 11
    // d = 1
    // Numbers: 1, 10, 11
    // Return: [3, 22, 110]

    public class Numbers
    {
        public static long[] NumbersWithDigitInside(long x, long d)
        {
            long sum = 0;
            long product = 1;

            List<long> numbers = new List<long>();
            long[] result = new long[3];

            for (int i = 1; i <= x; i++)
            {
                if (i.ToString().Contains(d.ToString()))
                {
                    numbers.Add(i);
                    sum += i;
                }
            }

            foreach (long number in numbers)
            {
                product *= number;
            }

            if (numbers.Count == 0)
            {
                product = 0;
            }

            result[0] = numbers.Count;
            result[1] = sum;
            result[2] = product;

            return result;
        }
    }
}
