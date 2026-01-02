namespace Task5;

public class Program
{
    public static void Main(string[] args)
    {
        int m = int.Parse(Console.ReadLine());
        float[,] d = new float[m, m];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                do
                {
                    d[i, j] = float.Parse(Console.ReadLine());
                } while (d[i, j] < -999.99 || d[i, j] > 999.999);
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

        int a=int.Parse(Console.ReadLine());
        int b=int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++) 
            { 
                if(d[i, j] <a || d[i, j] > b)
                {
                    d[i, j] *= 2;
                }
            }
        }

        float temp;
        for(int i = 0;i < m; i++)
        {
            for(int j = 0;j < i; j++)
            {
                temp=d[i, j];
                d[i, j] = d[j, i];
                d[j,i] = temp;
            }
        }

        Console.WriteLine("Doubled and Transposed matrix");
        for(int i = 0; i < m; i++)
        {
            for( int j = 0; j < m; j++)
            {
                Console.Write(d[i, j]+" ");
            }
            Console.WriteLine();
        }

    }
}