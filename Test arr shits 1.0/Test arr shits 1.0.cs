using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_arr_shits_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr =  { "hello", "hello", "pesho", "hello", "four", "two", "gosho", "gosho", "pesho", "six", "gosho" };
            List<string> word = new List<string>()
            {
                "hello"
            };
            Console.WriteLine(!word.Contains(arr[0]));
        }
    }
}
