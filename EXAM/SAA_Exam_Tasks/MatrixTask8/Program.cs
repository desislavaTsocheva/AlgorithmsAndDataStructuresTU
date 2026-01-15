//Даден е двумерен масив. Да се обходи вторичният диагонал и да се намери НОД на всички
//елементи, кратни на k.

namespace MatrixTask8;

public class Program
{
    public static int GCD(int a,int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a=temp;
        }
        return a;
    }
    public static void Main(string[] args)
    {
        int[,] matrix = {
            { 12, 24, 36, 48 },
            { 60, 15, -25, 72 },
            { 85, 35, -45, 96 },
            { -10, 20, 30, 40 }
        };
        int k = 3;
        int gcd = 0;
        for(int i = 0; i < 4; i++)
        {
           
            for(int j = 0; j < 4; j++)
            {
               
                if ( (j == (4 - 1) - i) && (matrix[i,j]%3==0))
                { 
                    int currect = matrix[i, j];
                    int f = matrix[0, 0];
                    gcd=GCD(f,currect);
                }
            }
        }
        Console.WriteLine(gcd);
    }
}