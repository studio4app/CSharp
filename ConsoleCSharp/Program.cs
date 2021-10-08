using System;

namespace ConsoleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteMsgUseCondition();
            Console.ReadKey();
        }
        static void WriteMsgUseCondition(bool b = false)
        {
            if (b == true)
            {
                Console.WriteLine("NewBranch with condition: " + b);
            }
            else
            {
                Console.WriteLine("NewBranch with condition: " + b);
            }
        }
    }
}
