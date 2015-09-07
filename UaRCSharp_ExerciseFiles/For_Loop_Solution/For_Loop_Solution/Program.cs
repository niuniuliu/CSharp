using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // int raw = 1;
            // while(raw <= 8){

            //     if (raw % 2 == 1)
            //     {
            //         for(int counter = 0; counter < 4; counter++)
            //         {
            //             Console.Write("X");
            //             Console.Write("O");
            //         }
            //     }
            //     else
            //     {
            //         for(int counter = 0; counter < 4; counter++)
            //         {
            //             Console.Write("O");
            //             Console.Write("X");
            //         }

            //     }
            //     Console.WriteLine("");
            //     raw++;
            // }

            // string sValue = "init";
            // int first = 0;
            // ReturnMultiRef(ref first, ref sValue);
            // Console.WriteLine("{0}, {1}", first.ToString(), sValue);

            

            string sValue;
            int first;

            ReturnMultiOut(out first, out sValue);
            Console.WriteLine("{0}, {1}", first.ToString(), sValue);
            Console.ReadKey();
        }

         static void ReturnMultiRef(ref int i, ref string s)
         {
                i = 50;
                s = "using ref";
         }

        static void ReturnMultiOut(out int i, out string s)
        {
            i = 25;
            s = "using out";
        }


    }
}
