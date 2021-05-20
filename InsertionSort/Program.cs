using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            var algo = new Algorithm();
            algo.Inputs(size);
            algo.InsertionSort();
        }
    }
}
