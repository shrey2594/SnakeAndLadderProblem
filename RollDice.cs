﻿using System;
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
            int count=0;
            Random r = new Random();
            while (current < 100)
            {
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
                count++;
                Console.WriteLine("The player is currently at position "+current);
            }
            Console.WriteLine("The player took "+count+" rolls to win.");
        }
    }
}
