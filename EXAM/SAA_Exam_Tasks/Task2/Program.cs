namespace Task2;

public class Program
{
    public static void Main(string[] args)
    {
        int row=int.Parse(Console.ReadLine());
        int col=int.Parse(Console.ReadLine());
        int[,] d = new int[row, col];

        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                do
                {
                    d[i, j] = int.Parse(Console.ReadLine());
                } while (d[i, j] < -999 || d[i,j]>999);
            }
        }

        for(int i = 0; i < row; i++)
        {
            for( int j = 0; j < col; j++)
            {
                Console.Write(d[i,j]+" ");
            }
            Console.WriteLine();
        }

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int sum=0, count = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0;j < col; j++)
            {
                if(i<j && d[i,j]>=r && d[i, j] <= b && d[i,j]>=a && d[i, j] % r == 0)
                {
                    sum += d[i, j];
                    count++;
                }
            }
        }
        double average = sum / count;
        Console.WriteLine("Average: "+average);

    }
}