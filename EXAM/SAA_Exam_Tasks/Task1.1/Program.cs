//Да се сортира рекурсивно едномерен масив в нарастващ ред и да се преброят всички 
//елементи, които са палиндром по цифри (11, 121, 1331).

public class Program
{
    static void QuickSort(int[] arr, int left, int right)
    {
        int i = left, j = right, temp;
        int x = arr[(left + right) / 2];

        do
        {
            while (arr[i] < x) { i++; }
            while (arr[j] > x) { j--; }
            if (i <= j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        } while (i <= j);

        if (left < j) { QuickSort(arr, left, j); }
        if (i < right) { QuickSort(arr, i, j); }
    }

    static bool IsPalindrom(int n)
    {
        if (n < 0) return false;
        int original = n;
        long reversed = 0;
        while (n > 0)
        {
            reversed = reversed * 10 + (n % 10);
            n /= 10;
        }
        return original == reversed;
    }

    static void Main(string[]args)
    {
        Console.Write("Въведете броя на елементите: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Въведете елементите:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int palindromeCount = 0;
        foreach (int num in arr)
        {
            if (IsPalindrom(num))
                palindromeCount++;
        }

        QuickSort(arr, 0, n - 1);

        Console.WriteLine("\nСортиран масив:");
        Console.WriteLine(string.Join(", ", arr));
        Console.WriteLine($"\nБрой палиндроми: {palindromeCount}");
    }
}