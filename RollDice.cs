using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class RollDice
    {
        public static void Roll(int start)
        {
            int current = start;
            Random r = new Random();
            while (current <= 100)
            {
                int dice = r.Next(1, 7);
                int option = CheckOption.Options(dice);
                current+=option;
                if (current<0)
                {
                    current=0;
                }
            }
            Console.WriteLine(current);
        }
    }
}
