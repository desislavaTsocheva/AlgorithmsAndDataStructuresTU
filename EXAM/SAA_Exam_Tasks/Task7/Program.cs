namespace Task7;

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
                } while (d[i, j] < -500 || d[i, j] > 500);
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

        int[] minEl=new int[m];
        int[] maxEl=new int[m];
        for(int i = 0;i < m; i++)
        {
            int min = d[i, 0];
            int max= d[i, 0];
            for (int j = 0; j < m; j++)
            {
                if (d[i, j] < min) { min = d[i, j]; }
                if (d[i, j] > max) { max = d[i, j]; }
            }
            minEl[i] = min;
            maxEl[i] = max;
        }

        for(int i = 0; i < m; i++)
        {
            Console.Write(minEl[i]+" ");
        }
        Console.WriteLine();

        for(int i = 0;i<m; i++)
        {
            Console.Write(maxEl[i]+" ");
        }
        Console.WriteLine();

        for(int i = 0; i < m; i++)
        {
            d[i, 0] = minEl[i];
            d[i,m-1]=maxEl[i];
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(d[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("M: ");
        int mm= int.Parse(Console.ReadLine());
        Console.WriteLine("N: ");
        int n = int.Parse(Console.ReadLine());
        int counterGreaterThanM = 0;
        int counterSmallerThanN = 0;

        for (int i = 0; i < m; i++)
        {
            if (maxEl[i] > mm) { counterGreaterThanM++; }
            if (minEl[i] < n) {  counterSmallerThanN++; }
        }
        Console.WriteLine("Counter > m: "+counterGreaterThanM);
        Console.WriteLine("Counter < n: "+counterSmallerThanN);
    }
}
