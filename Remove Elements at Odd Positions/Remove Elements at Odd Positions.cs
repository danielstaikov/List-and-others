using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Elements_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> word = Console.ReadLine().Split(' ').ToList();

            for (int i = word.Count - 1; i >= 0; i --)
            {
                if (i%2==0)
                {

                    word.RemoveAt(i);

                }


            }

            for (int i = 0; i < word.Count; i++)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine();

        }
    }
}
