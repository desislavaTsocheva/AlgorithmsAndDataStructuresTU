using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MatrixMultiplication
{
    //29.Да се напише програма за умножение на матрици (A и B). Резултатът да се 
    //записва в трета матрица C.
    public class Program
    {
        static void Main(string[] args)
        {
            int rows1, cols1, rows2, cols2;
            Console.WriteLine("Enter rows for matrix 1: ");
            rows1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter cols for matrix 1: ");
            cols1 = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows1, cols1];

            Console.WriteLine("Enter elements for matrix 1: ");
            EnterElements(matrix);

            while (true)
            {
                Console.WriteLine("Enter rows for matrix 2: ");
                rows2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter cols for matrix 2: ");
                cols2 = int.Parse(Console.ReadLine());
                if (cols1 != rows2)
                {
                    Console.WriteLine("\n These matrix CANNOT be multiplied!");
                }
                else
                {
                    break;
                }
            }

            int[,] matrix2 = new int[rows2, cols2];
            Console.WriteLine("\nEnter elements for Matrix 2:");
            EnterElements(matrix2);

            int[,] matrix3 = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    matrix3[i, j] = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        matrix3[i, j] += matrix[i, k] * matrix2[k, j];
                    }
                }
            }

            Console.WriteLine("Matrix 1:");
            PrintMatrix(matrix);

            Console.WriteLine("\nMatrix 2:");
            PrintMatrix(matrix2);

            Console.WriteLine("\nMatrix 1 * Matrix 2:");
            PrintMatrix(matrix3);
        }

        static void PrintMatrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void EnterElements(int[,] elements)
        {
            for (int i = 0; i < elements.GetLength(0); i++)
            {
                for (int j = 0; j < elements.GetLength(1); j++)
                {
                    elements[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

    }
}

