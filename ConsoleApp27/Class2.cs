using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//using ConsoleApp26;

namespace ConsoleApp27;

public struct Move
{
    public static bool Horse(string firstCordinat, string secondCordinat)
    {
        char j1 = firstCordinat[0];
        int i1 = int.Parse(firstCordinat.Substring(1));
        char j2 = secondCordinat[0];
        int i2 = int.Parse(secondCordinat.Substring(1));
        int iDiference = Math.Abs(i1 - i2);
        int jDiference = Math.Abs(j1 - j2);
        return (iDiference == 2 && jDiference == 1) || (iDiference == 1 && jDiference == 2);
    }
    public static bool Queen(string firstCordinat, string secondCordinat)
    {
        char j1 = firstCordinat[0];
        int i1 = int.Parse(firstCordinat.Substring(1));
        char j2 = secondCordinat[0];
        int i2 = int.Parse(secondCordinat.Substring(1));
        int iDiference = Math.Abs(i1 - i2);
        int jDiference = Math.Abs(j1 - j2);
        return iDiference == 0 || jDiference == 0 || iDiference == jDiference;
    }
    public static bool Bishop(string firstCordinat, string secondCordinat)
    {
        char j1 = firstCordinat[0];
        int i1 = int.Parse(firstCordinat.Substring(1));
        char j2 = secondCordinat[0];
        int i2 = int.Parse(secondCordinat.Substring(1));
        int iDiference = Math.Abs(i1 - i2);
        int jDiference = Math.Abs(j1 - j2);
        return iDiference == jDiference;

    }
    public static bool Rook(string firstCordinat, string secondCordinat)
    {
        char j1 = firstCordinat[0];
        int i1 = int.Parse(firstCordinat.Substring(1));
        char j2 = secondCordinat[0];
        int i2 = int.Parse(secondCordinat.Substring(1));
        int iDiference = Math.Abs(i1 - i2);
        int jDiference = Math.Abs(j1 - j2);

        return iDiference == 0 || jDiference == 0;
    }
    public static bool King(string firstCordinat, string secondCordinat)
    {
        char j1 = firstCordinat[0];
        int i1 = int.Parse(firstCordinat.Substring(1));
        char j2 = secondCordinat[0];
        int i2 = int.Parse(secondCordinat.Substring(1));
        int iDiference = Math.Abs(i1 - i2);
        int jDiference = Math.Abs(j1 - j2);

        return iDiference == 0 && jDiference == 0 || iDiference == 0 && jDiference == 1;
    }
    public static void CheckFigureMove(string[,] map)
    {
        bool a = false;
        WriteLine("Enter a figure: K - King, B - Bishop , R - Rook , Horse - H , Queen - Q");
        char userInput = char.ToUpper(ReadKey().KeyChar);
        Write("Enter the first Coordinate: ");
        string firstCordinat = ReadLine();
        Write("Enter the second Cordinate ");
        string secondCordinat = ReadLine();
        switch (userInput)
        {
            case 'H':
                a = Horse(firstCordinat, secondCordinat);
                break;
            case 'B':
                a = Bishop(firstCordinat, secondCordinat);
                break;
            case 'R':
                a = Rook(firstCordinat, secondCordinat);
                break;
            case 'Q':
                a = Queen(firstCordinat, secondCordinat);
                break;
            case 'K':
                a = King(firstCordinat, secondCordinat);
                break;
            default:
                WriteLine($"Invalid {userInput} move!");
                break;
        }
        if (a)
        {
            WriteLine($"Valid {userInput} move!");
      
        }
    }
    public enum CordinateWord : byte
    {
        A = 1, B = 2, C = 3, D = 4, E = 5, F = 6, G = 7, H = 8,
    }

}



