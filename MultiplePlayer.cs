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
    public class MultiplePlayer
    {
        /// <summary>
        /// Check winner between multiplayers .
        /// </summary>
        public static void Players(int start)
        {
            int isPlayer1Value=start;
            int isPlayer2Value=start;
            while(isPlayer1Value!=100 && isPlayer2Value!=100)
            {
                isPlayer1Value=RollDice.Roll(isPlayer1Value);
                isPlayer2Value=RollDice.Roll(isPlayer2Value);
            }
            if(isPlayer1Value==100)
            {
                Console.WriteLine("Player1 Wins");
            }
            else
            {
                Console.WriteLine("Player2 wins");
            }
        }
    }
}
