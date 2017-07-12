using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            List<string> word = new List<string>();
            List<int> occurrence = new List<int>();
            word.Add(arr[0]);

            for (int i = 0; i < word.Count; i++)
            {
                occurrence.Add(1);
                for (int j = 1; j < arr.Length; j++)
                {
                    if (!word.Contains(arr[j]))
                    {
                        word.Add(arr[j]);
                    }
                }
            }

            for (int i = 0; i < word.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (word[i] == arr[j])
                    {
                      count++;
                              
                    }
                }
                occurrence[i] = occurrence[i] + count-1;
            }

           List<int> resultList = new List<int>();
           List<string> resultStringList = new List<string>();

            for (int firstIndex = 0; firstIndex < occurrence.Count; firstIndex++)
            {
                int elementToInsert = occurrence[firstIndex];
                string stringToInsert = word[firstIndex];
                bool hasInserted = false;
                for (int secondIndex = 0; secondIndex < resultList.Count; secondIndex++)
                {
                    int currentListElement = resultList[secondIndex];
                    string currentStringElement = resultStringList[secondIndex];
                    if (elementToInsert > currentListElement)
                    {
                        resultList.Insert(secondIndex, elementToInsert);
                        resultStringList.Insert(secondIndex, stringToInsert);
                        hasInserted = true;
                        break;
                    }
                }

                if (!hasInserted)
                {
                    resultList.Add(elementToInsert);
                    resultStringList.Add(stringToInsert);
                }
            }

            for (int i = 0; i < resultList.Count; i++)
            {
                double percentage = (double)resultList[i]*100 / arr.Length;
                Console.WriteLine($"{resultStringList[i]} -> {resultList[i]} times ({percentage:F2}%)");
            }
        }
    }
}
