using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Hello in iteration" + i);
                Console.WriteLine("ChangesFromLocalMachine" + i*2);
            }
            Console.WriteLine("Hello" + 1);
        
        Console.ReadKey();
        }
    }
}
