using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HailStone
{
    class HailStoneMath
    {
        int Number;
        public HailStoneMath(int number)
        {
            Number = number;
        }
        public void printSequence()
        {
            var currnum = Number;
            while (currnum != 1)
            {
                Console.Write($"{currnum}, ");
                if (currnum % 2 == 0)
                {
                    currnum = currnum / 2;
                }
                else
                {
                    currnum = 3 * currnum + 1;
                }
            }
            Console.Write("1");
        }
    }
}
