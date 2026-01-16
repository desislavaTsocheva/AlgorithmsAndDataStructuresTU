//Да се определи средния по фолемина ел-т
//на второстепенния диагонал на масив 

public class Program
{
    public static void Main(string[] args)
    {
        int[,] a = {
            {1,2,3,4},
            {56,45,89,8},
            {23,5,98,5},
            {2,8,5,6}
        };
        int[] mid = new int[4];
        for(int i = 0; i <4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                if (j == (4 - 1) - i)
                {
                    mid[i] = a[i, j];
                    Console.Write(mid[i]+" ");
                }
            }
        }


        int midEl = 0;
        int ind = 1;
        for(int i = 0;i < 4; i++)
        {
            if (mid[i] < mid[ind] && mid[ind] < mid[ind + 1])
            {
                midEl = mid[ind];
            }
            else
            {
                midEl= mid[ind + 1];
            }
        }
        Console.WriteLine(midEl);
    }
}