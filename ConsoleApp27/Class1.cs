using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp27
{
    internal class Class1
    {
      public  static void PrintMap()
        {
            PrintWords();
            WriteLine();
            string[,] map = new string[8, 8];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        BackgroundColor = ConsoleColor.Yellow;
                    }
                    Write(" " + map[i, j] + " ");

                    BackgroundColor = ConsoleColor.Black;
                    if (j == 7)
                    {
                        Write("| " + Convert.ToString(i + 1));
                    }
                }

                WriteLine();
            }
        }
        static void PrintWords()
        {
            for (char num = 'A'; num <= 'H'; num++)
            {
                Write("" + num + " ");
            }
        }
        Move.CheckFigureMove()
    }
}
