using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            int[,] numbers2D = new int[arr.Length, 2];

            for (int i = 0; i < arr.Length; i++)
            {
                int[] type = arr[i].Split('.').Select(int.Parse).ToArray();
                numbers2D[i, 0] = type[0];
                numbers2D[(arr.Length - 1 - i), 1] = type[1];


            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (numbers2D[j, i] != 0)
                    {
                        Console.Write($"{(char)numbers2D[j,i]}");
                    }
                }

            }


            Console.WriteLine();

        }
    }
}
