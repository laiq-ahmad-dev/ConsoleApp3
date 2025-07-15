using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
        repeat:
            if (a < 100)
            {
                a++;
                Console.Write(a + " ");
                goto repeat;
            }
        }
    }
}
