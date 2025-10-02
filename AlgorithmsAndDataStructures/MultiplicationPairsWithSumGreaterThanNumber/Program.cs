//Напишете програма за намиране на произведението на всички елементи на
//едномерен масив, участващи в двойки, чиито суми са < 120.

Console.WriteLine("Enter array length: ");
int len = int.Parse(Console.ReadLine());
int[] array = new int[len];
int multiplication=1;
for (int i = 0; i < len; i++)
{
    Console.WriteLine($"Enter number {i} : ");
    array[i] = int.Parse(Console.ReadLine());
}
for(int i = 0;i < len-1; i++)
{
    if ((array[i] + array[i + 1]) > 120)
    {
        multiplication *= array[i] + array[i+1];
    }
}
Console.WriteLine($"Multiplication of pairs with sum greater than 120 is: {multiplication}");