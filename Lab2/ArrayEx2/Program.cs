using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx2
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

            int[] array = new int[row + 2];
            int mainDiagonal = 0;
            for(int i = 0;i < row; i++)
            {
                for(int j = 0;j < col; j++)
                {
                    if (i == j)
                    {
                        mainDiagonal += matrix[i, j];
                    }
                }
            }
            array[0] += mainDiagonal;

            int rowSum = 0;
            for( int i = 0; i < row; i++)
            {
                for(int j=0;j<col; j++)
                {
                    rowSum += matrix[i,j];
                }
                array[i+1] = rowSum;
                rowSum = 0;
            }

            int count = 0;
            for(int i=0; i<row; i++)
            {
                for(int j=0; j<col; j++)
                {
                    if(i > j && matrix[i,j]< i+j)
                    {
                        count++;
                    }
                }
            }
            array[row + 1] += count;

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
