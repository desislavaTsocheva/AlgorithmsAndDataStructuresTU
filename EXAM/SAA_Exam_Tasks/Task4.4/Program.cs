//Да се сортира рекурсивно едномерен масив в нарастващ ред и да се провери дали 
//съществуват три последователни елемента, образуващи аритметична прогресия

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

        bool found = false;

        for (int i = 0;i <= n-3; i++)
        {
            if (array[i + 1] - array[i] == array[i + 2] - array[i + 1])
            {
                Console.WriteLine($"\nНамерена прогресия: {array[i]}, {array[i + 1]}, {array[i + 2]}");
                Console.WriteLine($"Разлика (d) = {array[i + 1] - array[i]}");
                found = true;
                break;
            }
        }
        if(!found)
        {
            Console.WriteLine("\nНе съществуват три последователни елемента в аритметична прогресия.");
        }


    }
}