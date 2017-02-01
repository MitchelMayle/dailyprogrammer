using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketLogic
{
    // Vasya - Clerk
    // The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in a huge
    // line. Each of them has a single 100, 50 or 25 dollars bill. A "Avengers" ticket costs 25 dollars.
    // Vasya is currently working as a clerk. He wants to sell a ticket to every single person in this line.
    // Can Vasya sell a ticket to each person and give the change if he initially has no money and sells the tickets strictly in the
    // order people follow in the line?
    // Return YES, if Vasya can sell a ticket to each person and give the change. Otherwise return NO.

    // Line.Tickets(new int[] {25, 25, 50})  => YES
    // Line.Tickets(new int[] {25, 100}) => NO

    // I do not know why this does not work


    public class Line
    {
        public static string Tickets(int[] peopleInLine)
        {
            int balance = 0;
            const int TicketPrice = 25;

            for (int i=0; i < peopleInLine.Length; i++)
            {
                if (peopleInLine[i] - TicketPrice > balance)
                {
                    return "NO";
                }
                else
                {
                    balance += TicketPrice;           
                }
            }
            return "YES";
        }
    }
}
