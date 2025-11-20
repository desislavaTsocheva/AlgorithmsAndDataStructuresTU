using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter sum: ");
        int sum = int.Parse(Console.ReadLine());

        Console.Write("How much money do you have (count): ");
        int count = int.Parse(Console.ReadLine());

        int[] money = new int[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter coin: ");
            money[i] = int.Parse(Console.ReadLine());
        }

        SortDescending(money);

        Console.WriteLine("\nCoins used:");
        MakeChange(money, sum);
    }

    // Bubble Sort
    static void SortDescending(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static int FindGreatestCoin(int[] money, int sum)
    {
        for (int i = 0; i < money.Length; i++)
        {
            if (money[i] <= sum)
            {
                return money[i];
            }
        }

        return -1; 
    }

    static void MakeChange(int[] money, int sum)
    {
        if (sum == 0)
            return;

        int coin = FindGreatestCoin(money, sum);

        if (coin == -1)
        {
            Console.WriteLine("No coin fits for the remaining sum: " + sum);
            return;
        }

        Console.WriteLine(coin);
        MakeChange(money, sum - coin);
    }
}
