using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    public class DigitalRoot
    {
        public static int AddDigits(long n)
        {
            string converted = n.ToString();

            string[] numberString = new string[converted.Length];
            int[] intString = new int[converted.Length];

            for (int i=0; i < converted.Length; i++)
            {
                numberString[i] = converted[i].ToString();
                intString[i] = int.Parse(numberString[i]);
            }

            int sum = 0;

            for (int i=0; i<intString.Length; i++)
            {
                sum += intString[i];
            }

            if (sum >= 10)
            {

            }

            return sum;
           
        }
    }
}
