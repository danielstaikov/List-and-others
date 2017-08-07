using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Crisis
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberGiven = int.Parse(Console.ReadLine());
            List<int> resultList = new List<int>();
            int index = 0;
            int indexOfInversion = 0;
            int count = 0;

            for (int i = 0; i < numberGiven; i++)
            {
                List<int> listGiven = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                Console.WriteLine(string.Join(" ", listGiven));

                index = RightestElementSmallThan(resultList, listGiven[0]);// най-десния елемент по-малък от първия

                Console.WriteLine(index);

                indexOfInversion = IndexOfInvesion(listGiven); // проверяваме дали всеки следващ елемент е по-голям от предишния
                if (indexOfInversion< resultList.Count-1)
                {
                    //
                }
                else
                {
                    count = index;

                    for (int j = 0; j < listGiven.Count; j++)
                    {
                        resultList.Insert(count, listGiven[j]) ;
                        count++;
                        Console.WriteLine(string.Join(" ", resultList));
                    }
                }
                
            }
        }
        static int RightestElementSmallThan(List<int> resultList, int firstElement) // рови списъка и търси най-десния елемент по-малък от първия
        {
            int index = 0;
            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i] < firstElement)
                {
                    index = i;
                }
                else
                {
                    break;
                }
            }
            
            return index;
        }
        static int IndexOfInvesion(List<int> inputList)
        {
            int index = 0;
            // търси аномалия в подреждането
            return index;
        }
    }
}
