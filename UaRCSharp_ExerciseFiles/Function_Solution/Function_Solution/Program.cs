using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(32, 45);
        }

        static void Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
    }
}
