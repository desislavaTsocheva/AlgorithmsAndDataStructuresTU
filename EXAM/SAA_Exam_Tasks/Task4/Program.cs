namespace Task4;

public class Program
{
    public static void Main(string[] args)
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        float[,] d = new float[row, col];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                do
                {
                    d[i, j] = float.Parse(Console.ReadLine());
                } while (d[i, j] < -999.99 || d[i, j] > 999.999);
            }
        }

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(d[i, j] + " ");
            }
            Console.WriteLine();
        }

        for(int i= 0; i < row; i++)
        {
            for(int j = 0;j < col; j++)
            {
                
            }
        }

    }
}