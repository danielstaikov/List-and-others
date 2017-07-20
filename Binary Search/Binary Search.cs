using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int linearSearchCount = 0;
            bool isNumberFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (number==arr[i])
                {
                    isNumberFound = true;
                    linearSearchCount++;
                    break;
                }
                linearSearchCount++;
            }

            int binarySearchCount = 0;
            BubbleSort(arr);

            int lowerBound = 0; // ако дадеш границите от 1 до arr.Length ти гърми judge-a.
            int upperBound = arr.Length-1;
            int midPoint = 0;
            bool notNumberFound = true;

            while (notNumberFound)
            {

                midPoint = lowerBound + (upperBound - lowerBound) / 2;
                binarySearchCount++;

                if (arr[midPoint] < number)
                {
                    lowerBound = midPoint + 1;
                }
                else if (arr[midPoint] > number)
                {
                    upperBound = midPoint - 1;
                }
                else
                {
                    notNumberFound = false;
                }

                if (upperBound <= lowerBound)
                {
                    binarySearchCount++;
                    break;
                }

            }


            if (isNumberFound)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine($"Linear search made {linearSearchCount} iterations");
            Console.WriteLine($"Binary search made {binarySearchCount} iterations");

        }
        static void BubbleSort(int[] arr)
        {
            while (true)
            {

                bool swaped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
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
