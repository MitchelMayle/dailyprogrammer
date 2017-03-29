using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddIntCount
{
    public class Count
    {
        public static int FindOddInt(int[] seq)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            foreach (int number in seq)
            {
                if (numbers.ContainsKey(number))
                {
                    numbers[number]++;
                }
                else
                {
                    numbers.Add(number, 1);
                }
            }

            foreach (KeyValuePair<int, int> kvp in numbers)
            {
                if (kvp.Value % 2 == 1)
                {
                    return kvp.Key;
                }
            }

            return 0;
        }
    }
}
