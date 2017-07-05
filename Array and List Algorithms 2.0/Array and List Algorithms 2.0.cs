using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_List_Algorithms_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int minValue = int.MaxValue;
            // int minValue = arr.Min(); върши същата работа. arr.Max() съответно намира максималния елемент

            for (int i = 0; i < arr.Length; i++) // min Value
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];

                }
            }
            Console.WriteLine("Min Value is: " + minValue);

        }
    }
}
