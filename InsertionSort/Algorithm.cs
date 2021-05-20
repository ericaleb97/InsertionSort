using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class Algorithm
    {
        public int size { get; set; }
        public int[] unsortedList { get; set; }

        //Is current element that may be moved back//
        public int i = 1;
        //Previous element that may be moved forward//
        public int j = 1;
        public int temp = 0;

        public void Inputs(int size)
        {
            Console.WriteLine("How big do you want the array to be?");
            Console.WriteLine();

            size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter your array:");

            Console.WriteLine();

            unsortedList = new int[size];

            for (int i = 0; i < unsortedList.Length; i++)
            {
                unsortedList[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void InsertionSort()
        {
            while (i < unsortedList.Length)
            {
                j = i;

                while (j > 0 && unsortedList[j - 1] > unsortedList[j])
                {
                    temp = unsortedList[j];
                    unsortedList[j] = unsortedList[j - 1];
                    unsortedList[j - 1] = temp;
                    j--;
                }
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("Sorted array:");

            foreach (int num in unsortedList)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
