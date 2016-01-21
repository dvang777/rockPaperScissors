using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Score
    {
        int UScore;
        int CScore;
        bool? isVictorious;

        public Score()
        {
            if (isVictorious == true)
            {
                UScore = UScore + 1;
            }
            else if (isVictorious == false)
            {
                CScore = CScore + 1;
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}
