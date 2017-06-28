using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_lecture_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                1, 2, 3
            };

            list.Add(1);// това са стойности а не индекси
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine("Before");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            list.Remove(3); // маха елемента със стойност 3
            list.RemoveAt(0); // маха елемента със индекс 0
            //list.Clear(); // зачиства целия списък

            Console.WriteLine("After");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
