static int ArraySum(int[] arr,int n)
{
    if (n <= 0)
        return 0;
    return ArraySum(arr, n - 1) + arr[n - 1];
}
int[] arr = { 1, 2, 3 };
Console.WriteLine(ArraySum(arr,arr.Length));
