using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.make = "Chevrolet";
            myCar.model = "Camaro";
            myCar.color = "Black";

            myCar.Drive();
            myCar.Stop();

        }
    }
}
