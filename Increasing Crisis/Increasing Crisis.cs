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

            for (int i = 0; i < numberGiven; i++)
            {
                List<int> listGiven = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                index = RightestElementSmallThan(resultList, listGiven[0]);// най-десния елемент по-малък от първия
                // проверяваме дали всеки следващ елемент е по-голям от предишния

            }
        }
        static int RightestElementSmallThan(List<int> resultList, int firstElement )
        {
            int index = 0;
            // рови списъка и търси най-десния елемент по-малък от първия
            return index;
        }
    }
}
