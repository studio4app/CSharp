using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(()=>ShowHello("Thread #1"));
            thread1.Start();
            Thread thread2 = new Thread(() => ShowHi("Thread #2"));
            thread2.Start();

            Console.ReadKey();
        }
        static void ShowHello(string name)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} Hello Master Branch in iteration " + i, name);
                Thread.Sleep(1000);
            }
            Console.WriteLine("{0} ends", name);
        }
        static void ShowHi(string name)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} Hi Master Branch in iteration " + i, name);
                Thread.Sleep(1000);
            }
            Console.WriteLine("{0} ends", name);
        }
    }
}