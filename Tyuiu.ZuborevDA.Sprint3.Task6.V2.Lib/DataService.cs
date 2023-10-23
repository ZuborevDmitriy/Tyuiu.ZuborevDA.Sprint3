using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZuborevDA.Sprint3.Task6.V2.Lib
{
    public class DataService : ISprint3Task6V2
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int numberofdivisors = 0;
            for (x=startValue; x<= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        numberofdivisors++;
                    }
                }
            }
            return numberofdivisors;
        }
    }
}
