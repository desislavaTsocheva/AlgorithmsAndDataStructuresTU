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

        float[] max_el_col=new float[col];
        for(int i= 0; i < col; i++)
        {
            float max = d[0,i];
            for(int j = 1;j < col; j++)
            {
                if (d[i, j] > max)
                {
                    max = d[j, i];
                }
            }
            max_el_col[i] = max;
        }

        Console.WriteLine("MAX BY COL");
        for (int i = 0;i < row; i++)
        {
            Console.WriteLine(max_el_col[i]);
        }
        Console.WriteLine();

        float minimax = max_el_col[0];
        for (int i = 1; i < row; i++)
        {
            if (max_el_col[i] < minimax)
            {
                minimax=max_el_col[i];
            }
        }

        Console.WriteLine("MINIMAX: "+minimax);

    }
}