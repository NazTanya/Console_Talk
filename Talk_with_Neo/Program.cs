using System;
using System.Collections.Generic;
using System.Threading;

namespace Talk_with_Neo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            List<string> str = new List<string>{"Wake up Neo...", "The Matrix has you...",
                                                "Follow the white rabbite...", "Knoc, knoc Neo..." };
            for (int i = 0; i < str.Count; i++)
                Write_to_Console(str[i]);
        }
        public static  void Write_to_Console(string a)
        {
            Console.WriteLine(a);
            Thread.Sleep(5000);
            Console.Clear();
        }
    }
}
