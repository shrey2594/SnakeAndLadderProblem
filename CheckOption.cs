using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class CheckOption
    {
		public static int Options(int roll)
		{
			Random random = new Random();
			int option = random.Next(0, 3);
			switch (option)
            {
				case 0:return 0;
				case 1:return roll;
				case 2:return 0-roll;
				default:return 0;
            }
		}
    }
}
