using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "11 23 56";
            string[] type = input.Split(' ');
            string number = type[0].ToString();
            //kol = int.Parse(number);
            string cases = type[1];
            Console.WriteLine("Type[0] - " + number);
            Console.WriteLine("Type[1] - " + cases);
        }
    }
}
