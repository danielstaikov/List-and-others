using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            BubbleSort(arr);

            for (int i = 0; i < num; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();

        }
        static void BubbleSort(int[] arr)
        {
            while (true)
            {


                bool swaped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
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
        static void Swap(ref int first, ref int second)
        {
            int medial = first;
            first = second;
            second = medial;
        }
    }
}
