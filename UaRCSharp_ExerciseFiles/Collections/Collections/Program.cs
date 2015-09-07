using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Non-generic Collections
            ArrayList arrList = new ArrayList();
            Stack myStack = new Stack();
            Queue myQueue = new Queue();
            SortedList srtList = new SortedList();


            // Generic Collections
            Stack<int> intStack = new Stack<int>();
            Queue<char> charQ = new Queue<char>();
            SortedList<string, string> strList = new SortedList<string, string>();

        }
    }
}
