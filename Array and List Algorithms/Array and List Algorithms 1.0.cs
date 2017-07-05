using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_List_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberToFind = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < arr.Length; i++) // list.Conains-like
            {
                if (arr[i]==numberToFind)
                {
                    Console.WriteLine("Ellement was found");
                    return;
                }
            }
            Console.WriteLine("Ellement wasn't found");
           
        }
    }
}
