using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            List<int> numbers = new List<int>();
            int lastOne = 0;
            int count = 0;

            int num = 0;
            while (word != "stop")
            {
                try
                {

                    num = int.Parse(word);
                    count++;
                    numbers.Add(num);
                    if (numbers.Count > 1)
                    {
                        for (int i = numbers.Count - 1; i >= 1; i--)
                        {
                            int solv = 0;
                            solv = numbers[i];
                            numbers[i] = numbers[i - 1];
                            numbers[i - 1] = solv;
                        }
                    }

                }
                catch (Exception)
                {

                    if (word == "bang")
                    {
                        count--;
                        if (count >= 0)
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= AverageList(numbers))
                                {
                                    Console.WriteLine($"shot {numbers[i]}"); // махам елемент
                                    lastOne = numbers[i];
                                    numbers.Remove(numbers[i]);
                                    for (int j = 0; j < numbers.Count; j++) // намалям всички останали с 1
                                    {
                                        numbers[j]--;
                                    }
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"nobody left to shoot! last one was {lastOne}");
                            break;
 
                        }
                    }
                }
                word = Console.ReadLine();


            }
            if (count == 0)
            {
                Console.WriteLine($"you shot them all. last one was {lastOne}");

            }
            else if (count > 0)
            {
                Console.WriteLine($"survivors: {String.Join(" ", numbers)}");
            }

        }
        static int AverageList(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum = sum + numbers[i];
            }
            
            return sum / numbers.Count;
        }

    }
}
