using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    /// <summary>
    /// 
    /// </summary>
    public class RollDice
    {
        /// <summary>
        /// Roll the dice class.
        /// </summary>
        /// <param name="start">The start.</param>
        public static int Roll(int start)
        {
            int current = start;
            Random r = new Random();
            int dice = r.Next(1, 7);
            int option = CheckOption.Options(dice);
            current+=option;
            if (current<0)
            {
                current=0;
            }
            if(current>100)
            {
                current -= option;
            }
            return current;
        }
    }
}
