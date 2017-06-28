using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                if (nums[i]<0)
                {
                    nums.RemoveAt(i);
                }
            }

            if (nums.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = nums.Count-1 ; i >= 0; i--)
                {
                    Console.Write(nums[i] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
