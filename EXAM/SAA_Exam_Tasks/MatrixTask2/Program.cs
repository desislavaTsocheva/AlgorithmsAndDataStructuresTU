//• Даден е двумерен масив. Да се създаде едномерен масив, в който да се извлекат всички
//положителни елементи от главния диагонал. Да се обходи вторичният диагонал и да се:
//нулират всички отрицателни елементи
//да се сумират всички ненулеви елементи

//namespace MatrixTask1;

//public class Program
//{
//    public static void Main(string[] args)
//    {

//    }
//}

namespace MatrixTask2;

public class Program
{
    public static void Main(string[] args)
    {

        int[,] matrix = {
            { 12, 24, 36, 48 },
            { 60, 15, -25, 72 },
            { 84, 35, 45, 96 },
            { -10, 20, 30, 40 }
        };

        int[] arr = new int[4];
        int ind = 0;
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                if (i == j && matrix[i,j]>0)
                {
                    arr[ind]=matrix[i,j];
                    ind++;  
                }
            }
        }
        for(int i = 0;i < arr.Length; i++)
        {
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine();

        int sum = 0;
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                if (j == ((4 - 1) - i) && matrix[i,j]<0)
                {
                    matrix[i, j] *= -1;
                }
            }
        }
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if ( matrix[i, j] != 0)
                {
                    sum += matrix[i, j];
                }
            }
        }

        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(sum);
    }
}
