using System;

class Program
{
    static void Main()
    {
        Console.Write("Въведете брой елементи на масива (N): ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Елемент [{i}]: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Въведете брой елементи за НОД (K): ");
        int k = int.Parse(Console.ReadLine());

        if (k > n || k <= 0)
        {
            Console.WriteLine("Грешка: K трябва да е между 1 и N.");
            return;
        }

        QuickSortDescending(array, 0, n - 1);

        Console.WriteLine("\nСортиран масив (намаляващ ред):");
        Console.WriteLine(string.Join(", ", array));

        int resultGCD = array[0];
        for (int i = 1; i < k; i++)
        {
            resultGCD = GetGCD(resultGCD, array[i]);
        }

        Console.WriteLine($"\nНОД на първите {k} елемента е: {resultGCD}");
    }

    static void QuickSortDescending(int[] arr, int left, int right)
    {
        if (left >= right) return;

        int x = arr[(left + right) / 2];
        int i = left;
        int j = right;

        while (i <= j)
        {
            while (arr[i] > x) i++;
            while (arr[j] < x) j--;

            if (i <= j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }

        if (left < j) QuickSortDescending(arr, left, j);
        if (i < right) QuickSortDescending(arr, i, right);
    }

    static int GetGCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}