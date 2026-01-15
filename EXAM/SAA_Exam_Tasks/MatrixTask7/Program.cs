//Даден е двумерен масив. Да се обходи обиколката, да се извлекат в едномерен масив
//всички нечетни елементи, а всички положителни да се сумират.

namespace MatrixTask7;

public class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix = {
            { 12, 24, 36, 48 },
            { 60, 15, -25, 72 },
            { 85, 35, -45, 96 },
            { -10, 20, 30, 40 }
        };
        int[] arr = new int[16];
        int sum = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if(i == 0 || j == 0 || i == 3 || j == 3)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        arr[i] = matrix[i, j];
                    }
                    if(matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                    }
                    
                }
            }
        }
        for (int j = 0; j < arr.Length; j++)
        {
            Console.Write(arr[j] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(sum);
    }
}