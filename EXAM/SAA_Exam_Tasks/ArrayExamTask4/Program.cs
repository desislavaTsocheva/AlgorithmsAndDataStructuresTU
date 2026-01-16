//Съставете алгоритъм и процедура за обработка на масив $A$ с размерност $n \times n$ ($n \le 15$)
//от цели числа в диапазона от -20 до 20.Да се получи едномерен масив $B$ с размерност $n$,
//в който всеки елемент $B_i$ е сума от положителните елементи на съответния ред на масива $A$.
//Масивът $B$ да се сортира с алгоритъм с линейна сложност.


namespace ArrayExamTask4;

public class Program
{
    public static void Main(string[] args)
    {
        int[] b = new int[4];
        
        int[,] matrix = {
            { 12, 24, 36, 48 },
            { 60, 15, -25, 72 },
            { 84, 35, 45, 96 },
            { -10, 20, 30, 40 }
        };
        int sumRow = 0;
        int ind = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (matrix[i, j] > 0)
                {
                    sumRow += matrix[i, j];
                }
               
            } b[ind] = sumRow;
            ind++;
            sumRow = 0;
        }

        int maxVal = 300;
        int[] counts = new int[maxVal + 1];
        foreach (int val in b) counts[val]++;

        int index = 0;
        for (int i = 0; i <= maxVal; i++)
        {
            while (counts[i] > 0)
            {
                b[index++] = i;
                counts[i]--;
            }
        }

        for (int i = 0; i < 4; i++)
        {
            Console.Write(b[i] + " ");
        }
    }
}

