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
            ShowHello1();
            ShowHi1();

            Console.ReadKey();
        }
        static void ShowHello1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello Master Branch in iteration" + i);
            }
        }
        static void ShowHi1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hi Master Branch in iteration" + i);
            }
        }
    }
}