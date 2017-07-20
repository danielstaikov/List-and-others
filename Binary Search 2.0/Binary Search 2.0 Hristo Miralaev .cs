using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void LinearSearch(List<string> list, int n, int counter)
        {
            for (int i = 0; i < list.ToArray().Length; i++)
            {
                counter++;
                if (int.Parse(list[i]) == n)
                {
                    Console.WriteLine("Yes");

                    break;
                }
                else if (i == list.ToArray().Length - 1 && int.Parse(list[i]) != n)
                {
                    Console.WriteLine("No");
                }
            }
            Console.WriteLine("Linear search made {0} iterations", counter);
        }
        static void BinarySearch(List<string> list, int number, int counter)
        {
            list.Sort();
            int midindex = 0, firstindex = 0, lastindex = list.ToArray().Length - 1;
            while (firstindex < (lastindex+1)) // вариации на тема <=, +1 и т.н.
            {
                counter++;
                midindex = firstindex + (lastindex - firstindex) / 2;
                if (number < int.Parse(list[midindex]))
                    lastindex = midindex - 1;
                if (number > int.Parse(list[midindex]))
                {
                    firstindex = midindex + 1;
                }
                if (number == int.Parse(list[midindex]))
                {
                    break;
                }
            }
            Console.WriteLine("Binary search made {0} iterations", counter);
        }
        static void Main(string[] args)
        {
            int counter = 0;
            string numbers = Console.ReadLine();
            List<string> list = numbers.Split(' ').ToList();
            int theNumber = int.Parse(Console.ReadLine());
            LinearSearch(list, theNumber, counter);
            BinarySearch(list, theNumber, counter);


        }
    }
}
