using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
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
            int perimeter = 0;

            for (int i = 0; i < row - 1; i++)
            {
                int row1 = matrix[0, i];
                int row3 = matrix[row - 1, i];
                perimeter += row1;
                perimeter += row3;
            }
            int col1 = 0;
            int col2 = 0;
            for (int j = 0; j < col - 1; j++)
            {
                col1 = matrix[0, j + 1];
                col2 = matrix[row - 1, j + 1];
                perimeter += col1;
                perimeter += col2;
            }

            Console.WriteLine("Perimeter= " + perimeter);
        }
    }
}