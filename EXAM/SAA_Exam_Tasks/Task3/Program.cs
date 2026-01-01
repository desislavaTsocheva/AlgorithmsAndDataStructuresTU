namespace Task3;

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

        float[,] newArr = new float[row, col];
        int count = 0;
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        for (int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                if (d[i, j] >= m && d[i,j] <= n && d[i,j]<0)
                {
                    d[i, j] = q; count++;
                   
                } 
                newArr[i, j] = d[i, j];
            }
        }

        for(int i = 0; i < row; i++)
        {
            for( int j = 0; j < col; j++)
            {
                Console.Write(newArr[i,j]+" ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Counter:"+count);

    }
}