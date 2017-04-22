using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for automated. \nPress 2 for user controlled.");
            int styleOfPlay = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Press 1 for blinker.\nPress 2 for user toad.\nPress 3 for user beacon.\nPress 4 for user pulsar.\nPress 5 for user pentadecathlon.");
            int typeOfOscillator = Int32.Parse(Console.ReadLine());

            GameOfLife theGameOfLife = new GameOfLife(typeOfOscillator);

            if (styleOfPlay == 1)
            {
                while (true)
                {
                    theGameOfLife.Iterate();
                    Thread.Sleep(500);
                }
            }
            else
            {
                while (true)
                {
                    theGameOfLife.Iterate();
                    Console.ReadLine();
                }
            }
        }
    }
}
