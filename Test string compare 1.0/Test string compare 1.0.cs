using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_string_compare_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abdr";
            string o1 = "bcdr";
            Console.WriteLine($" {s1.CompareTo(o1)}");

        }
    }
}
