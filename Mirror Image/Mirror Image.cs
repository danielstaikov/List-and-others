using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirror_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputCollection = Console.ReadLine().Split(' ').ToArray();
            bool notPrint = true;
            int index = 0;

            while (notPrint)
            {
                string inputString = Console.ReadLine();
                if (inputString=="Print")
                {
                    notPrint = false;
                }
                else
                {
                    index = int.Parse(inputString);
                    string medial = String.Empty;
                    for (int i = 0; i < index/2; i++)// елементите преди индекса
                    {
                        medial = inputCollection[index - 1 - i];
                        inputCollection[index - 1 - i] = inputCollection[i];
                        inputCollection[i] = medial;
                    }

                    int count = 0;
                    for (int i = index+1; i < (index + 1)+(inputCollection.Length-(index+1))/2; i++)// елементите след индекса
                    {
                        medial = inputCollection[inputCollection.Length-1 - count];
                        inputCollection[inputCollection.Length-1 - count] = inputCollection[i];
                        inputCollection[i] = medial;
                        count++;
                    }

                }

            }

            Console.WriteLine(string.Join(" ", inputCollection));
        }
    }
}
