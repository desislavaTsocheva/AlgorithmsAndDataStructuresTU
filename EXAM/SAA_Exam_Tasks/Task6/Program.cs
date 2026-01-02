namespace Task4;

public class Program
{
    public static void Main(string[] args)
    {
        int m = int.Parse(Console.ReadLine());
        int[,] d = new int[m, m];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                do
                {
                    d[i, j] = int.Parse(Console.ReadLine());
                } while (d[i, j] < 0 || d[i, j] > 99);
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(d[i, j] + " ");
            }
            Console.WriteLine();
        }

        int min, max, min_row, min_col, max_row, max_col;
        min = max = d[0, 0];
        min_col = min_row = max_col = max_row = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (min > d[i, j])
                {
                    min = d[i, j];
                    min_row = i;
                    min_col = j;
                }
                if (max < d[i, j])
                {
                    max = d[i, j];
                    max_row = i;
                    max_col = j;
                }
            }
        }

        Console.WriteLine($"Min element: {min} on [{min_row},{min_col}]");
        Console.WriteLine($"Max element: {max} on [{max_row},{max_col}]");

        int temp;
        for (int i = 0; i < m; i++)
        {
            temp = d[min_row, i];
            d[min_row, i] = d[max_row, i];
            d[max_row, i] = temp;
        }

        Console.WriteLine("Swaped: ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(d[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}