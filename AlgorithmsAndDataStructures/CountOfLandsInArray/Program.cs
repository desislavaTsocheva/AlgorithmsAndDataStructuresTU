//Напишете програма за намиране на броя на площадките (площадка - два или повече
//съседни еднакви елементи) на едномерен масив.

Console.WriteLine("Enter array length: ");
int len = int.Parse(Console.ReadLine());
int[] array = new int[len];
int counter = 0;
for (int i = 0; i < len; i++)
{
    Console.WriteLine($"Enter number {i} : ");
    array[i] = int.Parse(Console.ReadLine());
}
for (int i = 0;i < len-1; i++)
{
    if (array[i] == array[i + 1])
    {
        counter++;
    }
}
Console.WriteLine($"Count lands in array is: {counter}");