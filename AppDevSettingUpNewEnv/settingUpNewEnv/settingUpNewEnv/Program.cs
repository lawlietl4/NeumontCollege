using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace settingUpNewEnv
{
    class Program
    {
        
        Random _random = new Random();
        //string input = "";
        static void Main(string[] args) 
        {
            Program p = new Program();
            p.NumGuess();
        }
        void NumGuess()
        {
            int GuessNum = 0;
            int guess;
            int input;
            //bool outcome = false;
            while (true)
            {
                Console.WriteLine("Please input the number for your largest number...");
                input = Convert.ToInt32(Console.ReadLine());
                int num = RandomNumberGen(0, input);
                Console.WriteLine("Please input your guess...");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == num)
                {
                    WinCondition();
                }
                else
                { 
                    while (GuessNum < 5) {
                        if(guess != num)
                        {
                            GuessNum += 1;
                            Console.WriteLine("Please try again");
                            guess = Convert.ToInt32(Console.ReadLine());
                            if (GuessNum== 5)
                            {
                                LossCondition();
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
            }

        }
        void ProgramEnd()
        {
            string test = Console.ReadLine();
            if (test == "y")
            {
                NumGuess();
            }
            else if (test == "n")
            {
                Console.WriteLine("thank you for playing!");
                Environment.Exit(1);
            }
        }
        int RandomNumberGen(int min, int max)
        {
            return _random.Next(min, max);
        }
        void LossCondition()
        {
            Console.WriteLine("You did not guess in the allotted number of guesses\nPlay again?(y/n)...");
            ProgramEnd();
        }
        void WinCondition()
        { 
            Console.WriteLine($"Congratulations! You guessed correct\nPlay again?(y/n)...");
            ProgramEnd();
        }
    }
}