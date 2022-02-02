using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch runtime = new Stopwatch();
            runtime.Start();
            while (true)
            {
                Stopwatch funcTime = new Stopwatch();
                
                Console.WriteLine("Enter the string which you want to be translated. Enter ~ anywhere in the message to exit");
                MorseCode m1 = new MorseCode(Console.ReadLine());
                Console.WriteLine(m1.ToString());

                Console.WriteLine("Do you want it to be played? (Y/N)");
                if (Console.ReadLine().ToLower() == "y")
                { funcTime.Start(); m1.PlayCode(); funcTime.Stop(); Console.WriteLine("// It took {0} miliseconds to do this",funcTime.ElapsedMilliseconds); }

                Console.WriteLine("Do You want to translate another string? (Y/N)");
                if (Console.ReadLine().ToLower() == "n")
                {
                    runtime.Stop();
                    Console.WriteLine("runtime: {0}",runtime.ElapsedMilliseconds);
                    Console.ReadLine(); break;
                }
            }
        }
    }
}
