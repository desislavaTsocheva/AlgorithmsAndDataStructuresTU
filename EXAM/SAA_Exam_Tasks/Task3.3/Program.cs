//Да се сортира рекурсивно едномерен масив в нарастващ ред и да се намери 
//максималният елемент от тези, за които НОД(array[i], K) > 1. 

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
                i++; j--;
            }
        } while (i <= j);
        if (left < j) { QuickSort(arr, left, j); }
        if (i < right) { QuickSort(arr, i, right); }
    }

    static int GCD(int a,int b)
    {
        a=Math.Abs(a);
        b=Math.Abs(b);
  
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
        Console.Write("Въведете брой елементи (N): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Невалидно число.");
            return;
        }

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Елемент [{i}]: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        QuickSort(array, 0, n - 1);

        Console.WriteLine("\nСортиран масив:");
        Console.WriteLine(string.Join(", ", array));

        int maxElement = 0;
        bool found = false;
        Console.Write("Въведете числото K: ");
        int k = int.Parse(Console.ReadLine());

        for (int i = n - 1; i >= 0; i--)
        {
            if (GCD(array[i], k) > 1)
            {
                maxElement = array[i];
                found = true;
                break; 
            }
        }

        if (found)
        {
            Console.WriteLine($"\nМаксималният елемент, за който НОД(array[i], {k}) > 1, е: {maxElement}");
        }
        else
        {
            Console.WriteLine($"\nНе е намерен елемент, който да има общ делител с {k}, по-голям от 1.");
        }
    }
}