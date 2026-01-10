//Да се сортира рекурсивно едномерен масив в нарастващ ред и да се провери дали е 
//огледално симетричен по абсолютна стойност: 

public class Program
{
    static void QuickSort(int[]arr,int left,int right)
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
        if (left < j) { QuickSort(arr,left,j); }
        if (i < right) {  QuickSort(arr,i,right); }
    }

    static bool CheckForSymmetry(int[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            if (Math.Abs(arr[i]) != Math.Abs(arr[arr.Length - 1 - i]))
            {
                return false;
            }
        }
        return true;
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

        bool isMirrorSymmetric = CheckForSymmetry(array);

        if (isMirrorSymmetric)
        {
            Console.WriteLine("\nМасивът Е огледално симетричен по абсолютна стойност.");
        }
        else
        {
            Console.WriteLine("\nМасивът НЕ Е огледално симетричен по абсолютна стойност.");
        }
    }
}
