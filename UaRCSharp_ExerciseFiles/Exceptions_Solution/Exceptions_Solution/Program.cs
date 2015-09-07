using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = 32;
            object objValue = intValue;
            string strValue;

            strValue = (string)objValue;
        }
    }
}
