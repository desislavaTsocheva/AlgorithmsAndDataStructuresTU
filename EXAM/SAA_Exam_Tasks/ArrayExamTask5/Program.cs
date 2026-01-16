namespace MatrixTask1;

public class Program
{
    public static void Main(string[] args)
    {
        int[] a = new int[] { 1, 2, 35, 4, 53, 6, 700, 81, 9, 102, 112, 12, 1354, 14 };
        int min = a[0], max = a[0];
        
        for(int i=0;i<a.Length; i++)
        {
            if(a[i] < min)
            {
                min = a[i];
            }
            if (a[i] > max) 
            {
                max= a[i];
            }
        }

        int maxVal = 2000;
        int[] counts = new int[maxVal + 1];
        foreach (int val in a) counts[val]++;

        int index = 0;
        for (int i = 0; i <= maxVal; i++)
        {
            while (counts[i] > 0)
            {
                a[index++] = i;
                counts[i]--;
            }
        }


        int mid = a[14 / 2];
        double S1 = (min + max + mid) / 3.0;

        Console.WriteLine(min);
        Console.WriteLine(max);
        Console.WriteLine(mid);
        Console.WriteLine((min+max+mid)/3);
    }
}