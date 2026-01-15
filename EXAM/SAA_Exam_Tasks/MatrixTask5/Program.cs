//Даден е двумерен масив. Да се обходи по колони, като в едномерен масив да се
//извлекат най-големите отрицателни стойности по колони, а ако в колона няма
//такава – да се запише 0.


namespace MatrixTask5;

public class Program
{
    public static void Main(string[] args)
    {

        int[,] matrix = {
            { 12, 24, 36, 48 },
            { 60, 15, -25, 72 },
            { 84, 35, -45, 96 },
            { -10, 20, 30, 40 }
        };

        int[] arr = new int[4];
        
        for (int j = 0; j < 4; j++)
        {
            int el = 0;
            bool found = false;
            for (int i = 0; i < 4; i++)
            {
                if (matrix[i, j] <0)
                {
                    el = matrix[i, j];
                    found = true;
                }
            }
            if (found = false)
            {
                arr[j] = 0;
            }
            else
            {
                arr[j] = el;
            }
        }

        for (int j = 0; j < arr.Length; j++)
        {
            Console.Write(arr[j] + " ");
        }
        Console.WriteLine();

    }
}