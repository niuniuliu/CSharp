using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] fruit = { "Apples", "Oranges", "Grapes" };


            string[] myarray = { "Robert Barwell", "Mike Parry", "Jeremy Beacock" };

            string[] my_array;
            my_array = new string[3];
            Console.WriteLine(my_array.Count());
            

            foreach (var item in my_array)
            {
                Console.WriteLine(item);
                // Console.WriteLine(item.GetType() == typeof(int));
            }

            int i = 5;
            Console.WriteLine(i.GetType() == typeof(int));
            Console.WriteLine("i is an int {0} ", i.GetType() == typeof(int));
            Console.WriteLine("i is an int {0} ", typeof(int).IsInstanceOfType(i));

            // string[] fruit = { "Apples", "Oranges", "Grapes" };
            Console.WriteLine(string.Join("<>", fruit));
            Console.WriteLine(fruit);
            Console.ReadKey();

        }
    }
}
