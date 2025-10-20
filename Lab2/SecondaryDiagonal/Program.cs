using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondaryDiagonal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row= ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter col= ");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int secDiagonalSum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i + j == row-1)
                    {
                        secDiagonalSum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Sum of the second diagonal elements is: {secDiagonalSum} ");


        }
    }
}
