using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split(' ');
            List<char> letters = new List<char>();
            int sum = 0;
            for (int i = 0; i < inputTokens.Length; i++)
            {
                char[] word = inputTokens[i].ToCharArray();
                for (int j = 0; j < word.Length; j++)
                {
                    letters.Add(word[j]);
                }
            }
            for (int i = 0; i < letters.Count; i++)
            {
                sum = sum + letters[i];
            }
            
            Console.WriteLine(String.Join($"{char.ToUpper((char)(sum / letters.Count))}", inputTokens));
        }
    }
}
