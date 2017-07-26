using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Japanese_Roulette
{
    class Program
    {
        static int cylinderLenghtVar = 0;
        static void Main(string[] args)
        {
            int[] cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] rotation = Console.ReadLine().Split(' ').ToArray();
            int index = 2;
            cylinderLenghtVar = cylinder.Length;
            bool isSurvive = true;
            for (int i = 0; i < rotation.Length; i++)
            {
                index = RotatingCylinder(rotation[i], cylinder.Length, index);//въртя цилиндъра
                if (cylinder[index] ==1)// сравнявам с индекса от cylinder[]
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    isSurvive = false;
                    break;
                }
                index--;
            }
            if (isSurvive)
            {
                Console.WriteLine("Everybody got lucky!");
            }

        }
        static int RotatingCylinder(string rotation, int length, int index)
        {
            string[] shot = rotation.Split(',').ToArray();
            int turn = int.Parse(shot[0]);
            if (turn> length)
            {
                do
                {
                    turn = turn - length;
                } while (turn > length); // врътката е с дължина по-малка или равна на масива
            }

            if (shot[1]== "Right")
            {
                index = RotatingRight(turn, index); //въртя цилиндъра и броя индекса
            }
            else
            {
                index = RotatingLeft(turn, index); //въртя цилиндъра и броя индекса
            }


            return index;

        }
        static int RotatingRight(int turn, int index)
        {
            for (int i = 0; i < turn; i++)
            {
                if (index<=0)
                {
                    index = index + 5;
                }
                else
                {
                    index--;
                }

            }

            return index;
        }
        static int RotatingLeft(int turn, int index)
        {
            for (int i = 0; i < turn; i++)
            {
                if (index >= cylinderLenghtVar-1)
                {
                    index = index - 5;
                }
                else
                {
                    index++;
                }

            }

            return index;
        }
    }
}
