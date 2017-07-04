using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int index = nums.Count - 1;
            int count = 0;
            for (int i = nums.Count-1; i >=0; i--)
            {
                
                for (int j = 0; j < nums.Count; j++)
                {
                    if (nums[index]==nums[j])
                    {
                        count++;
                        if (count>=2)
                        {
                            nums.RemoveAt(i);
                        }
                    }

                }
                count = 0;
                index--;
            }

                for (int i = 0; i < nums.Count; i++)
                {
                    Console.Write(nums[i] + " ");
                }
                Console.WriteLine();

        }
    }
}
