namespace Task1;

public class Program
{
    static void Main(string[] args)
    {
        int row = 3;
        int col = 3;
        float[,] a = new float[row, col];

        Console.WriteLine("ENTER ELEMENTS: ");
        Console.WriteLine();
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                do
                {
                    Console.WriteLine($"Enter {i},{j} element");
                    a[i, j] = float.Parse(Console.ReadLine());
                } while (a[i, j] <= -999.9 || a[i, j] >= 999.999);
            }
        }

        Console.WriteLine("MATRIX: ");
        Console.WriteLine();
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }

        float[] array = new float[row * col];
        int pos = 0;
        for (int i = 0;i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                if (a[i, j] > 0)
                {
                    array[pos]= a[i, j];
                    pos++;
                }
            }
        }

        for (int i = 0; i < pos-1; i++)
        {
            int min = i;
            for (int j = i + 1; j < pos; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }

            float temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }
        Console.WriteLine("SORT: ");
        Console.WriteLine();
        for(int i= 0; i < pos; i++)
        {
            Console.Write(array[i]+" ");
        }
    }
}