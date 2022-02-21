using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class RollDice
    {
        public static void Roll()
        {
            Random r = new Random();
            int dice=r.Next(1,7);
            Console.WriteLine(dice);
        }
    }
}
