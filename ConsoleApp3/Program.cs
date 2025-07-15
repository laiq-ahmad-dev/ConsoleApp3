using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";

            char[] ch = str.ToCharArray();
            str = "";
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                str = str + ch[i];
            }

            Console.WriteLine($"Display string after reverse \n{str}");
        }
    }
}
