using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberToFind = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == numberToFind)
                {
                    Console.WriteLine("yes");
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
