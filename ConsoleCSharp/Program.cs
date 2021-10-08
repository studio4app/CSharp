using System;

namespace ConsoleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteMsgUseCondition(); // function checking condition what should be written
            Console.ReadKey();
        }
        static void WriteMsgUseCondition(bool b = false) // by default it's false argument
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
