//Даден е двумерен масив. Да се намери НОД на:
//всички елементи от обиколката
//всички останали елементи

namespace MatrixTask1;

public class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix = {
            { 12, 24, 36, 48 },
            { 60, 15, 25, 72 },
            { 84, 35, 45, 96 },
            { 10, 20, 30, 40 }
        };

        int perimeter = 0;
        bool isPerimeter = false;
        int inner = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                isPerimeter = (i == 0 || i == 4 - 1 || j == 0 || j == 4 - 1);
                if (isPerimeter)
                {
                    if (perimeter == 0)
                    {
                        perimeter = matrix[i, j];
                    }
                    perimeter = GCD(perimeter, matrix[i, j]);
                }
                else
                {
                    if (inner == 0)
                    {
                        inner = matrix[i, j];
                    }
                    inner = GCD(inner, matrix[i, j]);
                }

            }
        }
        Console.WriteLine(perimeter);
        Console.WriteLine(inner);

        static int GCD(int x, int y)
        {
            while (y != 0)
            {
                int temp = y;  //18 //12
                y = x % y; //12=18%12=2
                x = temp;
            }
            return x;
        }
    }
}






