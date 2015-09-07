using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string errorMessage;

            try
            {
                Divide();
            }

            catch (OverflowException ofEx)
            {
                errorMessage = ofEx.Message;
                Console.WriteLine(errorMessage);
            }
            catch (DivideByZeroException dEx)
            {
                errorMessage = dEx.Message;
                Console.WriteLine(errorMessage);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                Console.WriteLine(errorMessage);
            }
        }

        static void Divide()
        {
            int numerator;
            int denominator;
            int result;

            Console.WriteLine("Enter the numerator");
            numerator = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter the denominator");
            denominator = Int32.Parse(Console.ReadLine());

            try
            {
                result = numerator / denominator;

                Console.WriteLine();
                Console.WriteLine("The result is: " + result);
            }

            catch (DivideByZeroException dEx)
            {
                throw new Exception("Division by zero is not permitted, please change the denominator", dEx.InnerException);
            }
        }
    }
}
