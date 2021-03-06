﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            BubbleSort(arr);

            Console.WriteLine(string.Join(" ", arr));
        }
        static void BubbleSort(string[] arr)
        {
            while (true)
            {

                bool swaped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0 )
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                        swaped = true;
                    }
                }
                if (!swaped)
                {
                    break;
                }
            }
        }
        static void Swap(ref string first, ref string second)
        {
            string medial = first;
            first = second;
            second = medial;
        }
    }
}
