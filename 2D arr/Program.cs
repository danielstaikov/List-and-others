using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };
            numbers[3, 1] = 5;

            //int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            // Or use the short form:
            // int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
