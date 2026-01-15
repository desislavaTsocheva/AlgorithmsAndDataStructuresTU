//Даден е двумерен масив. Да се обходи в зигзагообразен ред по редове.
//Да се намери
//НОД на всички четни елементи.

namespace MatrixTask1;

public class Program
{
    static int GetGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }
    public static void Main(string[] args)
    {

    }
}