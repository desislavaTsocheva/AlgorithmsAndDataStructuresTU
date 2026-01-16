//Условие: Трябва да намерим сечението на три масива $A$, $B$ и $C$,
//които съдържат само уникални елементи в диапазона $[1, 100]$.

namespace ArrayExamTask3;

public class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 23, 65, 2, 0, 5 };
        int[] b = { 65, 23, 2, 10, 5 };
        int[] c = { 23, 2, 65, 20, 50 };
        int[] counts = new int[101];

        foreach (int x in a) counts[x]++;
        foreach (int x in b) counts[x]++;
        foreach (int x in c) counts[x]++;

        int resultCount = 0;
        int resultCount2 = 0;
        for (int i = 0; i <= 100; i++)
        {
            if (counts[i] == 3)
            {
                resultCount++;
            }
            if (counts[i] == 1 || counts[i]==2)
            {
                resultCount2++;
            }
        }

        int[] newd = new int[resultCount];
        int[] newe = new int[resultCount2];
        int index = 0;

        for (int i = 0; i <= 100; i++)
        {
            if (counts[i] == 3)
            {
                newd[index] = i;
                index++;
            }
        }

        index = 0;
        for (int i = 0; i <= 100; i++) 
        {
            if (counts[i] == 1 || counts[i]==2)
            {
                newe[index] = i;
                index++;
            }
        }

        
        for (int i = 0;i < resultCount; i++)
        {
            Console.Write(newd[i]+" ");
        }
        Console.WriteLine(  );

        for (int i = 0;i < resultCount2; i++)
        {
            Console.Write(newe[i]+" ");
        }
        Console.WriteLine(  );


    }
}
