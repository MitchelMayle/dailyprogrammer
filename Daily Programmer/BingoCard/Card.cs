using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoCard
{
    public class Card
    {
        public string[] GenerateCard()
        {
            string[] bingo = new string[24];

            Random r = new Random();

            List<int> bList = new List<int>();
            List<int> iList = new List<int>();
            List<int> nList = new List<int>();
            List<int> gList = new List<int>();
            List<int> oList = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                int bColumn = r.Next(1, 16);

                if (!bList.Contains(bColumn))
                {
                    bList.Add(bColumn);
                    bingo[i] = "B" + bColumn.ToString();
                }
                else
                {
                    i--;
                }
            }
            for (int i = 5; i < 10; i++)
            {
                int iColumn = r.Next(16, 31);

                if (!iList.Contains(iColumn))
                {
                    iList.Add(iColumn);
                    bingo[i] = "I" + iColumn.ToString();
                }
                else
                {
                    i--;
                }
            }

            for (int i = 10; i < 14; i++)
            {
                int nColumn = r.Next(31, 46);

                if (!nList.Contains(nColumn))
                {
                    nList.Add(nColumn);
                    bingo[i] = "N" + nColumn.ToString();
                }
                else
                {
                    i--;
                }
            }

            for (int i = 14; i < 19; i++)
            {
                int gColumn = r.Next(46, 61);

                if (!gList.Contains(gColumn))
                {
                    gList.Add(gColumn);
                    bingo[i] = "G" + gColumn.ToString();
                }
                else
                {
                    i--;
                }
            }

            for (int i = 19; i < 24; i++)
            {
                int oColumn = r.Next(61, 76);

                if (!oList.Contains(oColumn))
                {
                    oList.Add(oColumn);
                    bingo[i] = "O" + oColumn.ToString();
                }
                else
                {
                    i--;
                }
            }

            return bingo;
        }
    }
}
