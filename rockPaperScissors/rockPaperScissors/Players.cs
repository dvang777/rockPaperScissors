using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    public class Players
    {
        string [] playersArray;

        public Players(string playerInput)
        {
            for (int i = 0; i < playersArray.Length; i++)
            {
                Console.WriteLine(playersArray[i]);
            }
        }
    }
}
