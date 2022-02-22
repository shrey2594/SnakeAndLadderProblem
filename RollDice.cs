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
            int dice=r.Next(1,7);
            Console.WriteLine(dice);
            int option = CheckOption.Options();
            Console.WriteLine(option);
            if(option==1)
            {
                Console.WriteLine("currently player is at:" + (current+dice));
            }
            else if(option==2)
            {
                Console.WriteLine("Currently player is at:" + (current-dice)); ;
            }
            else
            {
                Console.WriteLine("Currently player is at:" + current);
            }
        }
    }
}
