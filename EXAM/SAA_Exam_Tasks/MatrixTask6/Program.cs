//Даден е двумерен масив. Да се нулира всеки елемент, по-голям от средната стойност
//за реда си.

namespace MatrixTask6;

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

        
        for (int i = 0; i < 4; i++)
        {
            double avr = 0;
            int sum = 0;
            for(int j= 0; j < 4; j++)
            {
                sum+= matrix[i,j];
                
            }
            avr = sum / 4;
            for(int j = 0; j < 4; j++)
            {
                if (matrix[i, j] > avr)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
