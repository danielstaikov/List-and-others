using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputToken = Console.ReadLine().Split('|');
            List<int> list = new List<int>();

            for (int i = inputToken.Length-1; i >= 0; i--)
            {
               string[] subInputs = inputToken[i].Split(' ').ToArray();
                for (int j = 0; j < subInputs.Length; j++)
                {
                    if (subInputs[j]!=null)
                    {
                        char[] charSeparators = new char[] { ' ' };

                        string[] wordSearched = subInputs[j].Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

                        for (int k = 0; k < wordSearched.Length; k++)
                        {
                            Console.Write(wordSearched[k]+" ");
                        }
                        
                    }
                    
                }
                
            }

            Console.WriteLine();
        }
    }
}
