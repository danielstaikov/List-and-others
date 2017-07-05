using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_List_Algorithms_3._0_Revers_metod_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // arr = arr.Reverse().ToArray();// командата връща резултат, а не променя масива, 
            //                               //за това се налага резултата да се запише в масив

            int left = 0;
            int right = arr.Length - 1;

            while (left<(arr.Length/2))
            {
                int medial = arr[left];
                arr[left] = arr[right];
                arr[right] = medial;
                left++;
                right--;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
