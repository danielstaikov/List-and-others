using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit_Hole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputToken = Console.ReadLine().Split(' ').ToArray();
            int energyLimitation = int.Parse(Console.ReadLine());
            int index = 0;

            int energyRest = energyLimitation;
            do
            {
                string[] type = inputToken[index].Split('|').ToArray();
                string direction = type[0];

                if (direction=="Bomb")
                {
                    Console.WriteLine("You are dead due to bomb explosion!");
                    break;
                }
                else if (direction == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                else if (direction == "Left") //отместване на ляво?
                {
                    int jump = int.Parse(type[1]);
                    if (inputToken.Length < (jump + index))//?
                    {
                        index = jump - inputToken.Length - index;
                        while (index >= inputToken.Length)
                        {
                            index = index - inputToken.Length;
                        }
                    }
                    else
                    {
                        index = jump + index;
                    }
                    energyRest = energyRest - jump;
                }
                else // right
                {
                    int jump = int.Parse(type[1]);
                    if (inputToken.Length < (jump + index))//смятаме отместването на дясно
                    {
                        index = jump - inputToken.Length - index;
                        while (index >= inputToken.Length)
                        {
                            index = index - inputToken.Length;
                        }
                    }
                    else
                    {
                        index = jump + index;
                    }
                    energyRest = energyRest - jump;
                }

            } while (energyRest <= 0);


        }
    }
}
