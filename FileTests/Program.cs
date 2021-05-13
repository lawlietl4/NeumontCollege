using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTests
{
    class Program
    {
        static void Main(string[] args)
        {
            const int _max = 10000000;
            string FileName = @"..\..\TestFolder\TextFile1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
            Console.ReadLine();
        }
    }
}
