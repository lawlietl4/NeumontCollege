using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HailStone
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            if (args.Length != 1)
            {
                throw new Exception("Please provide a number");
            }
            if (int.TryParse(args[0], out number) && number >= 1)
            {
                var hail = new HailStoneMath(number);
                hail.printSequence();
            }
            else
            {
                throw new Exception("argument provided is not a valid number!");
            }
        }
    }
}
