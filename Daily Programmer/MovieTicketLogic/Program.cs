using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = new int[20] { 25, 25, 25, 100, 25, 25, 25, 100, 25, 25, 25, 100, 25, 50, 25, 100, 25, 25, 50, 100 };

            string answer = Line.Tickets(line);

            Console.WriteLine(answer);
        }
    }
}
