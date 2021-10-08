using System;

namespace ConsoleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteMessage writeMessage = new WriteMessage();
            writeMessage.Bool(true);
            Console.ReadKey();
        }
          }
}
