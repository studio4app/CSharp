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
            NewFunction();

            Console.ReadKey();
        }
        static void NewFunction()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello Master Branch in iteration" + i);
            }
        }
    }
}