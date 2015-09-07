using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.");
            int varInt = 1 / 3;
            float varFloat = 1 / 3;
            double varDouble = 1 / 3;
            decimal varDecimal = 1 / 3;

            Console.WriteLine(varInt);
            Console.WriteLine(varFloat);
            Console.WriteLine(varDouble);
            Console.WriteLine(varDecimal);

            Console.WriteLine("");
            Console.WriteLine(1.1234567890123456789012345678901234567890);
            Console.WriteLine(1.1234567890123456789012345678901234567890f);
            Console.WriteLine(1.1234567890123456789012345678901234567890d);
            Console.WriteLine(1.12345678901234567890123456789012345678901m);
        }
    }
}
