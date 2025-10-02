//Напишете програма за преброяване на всички двойки съседни елементи с различни знаци.

Console.WriteLine("Enter array length: ");
int len=int.Parse(Console.ReadLine());
int[]array=new int[len];
int counter = 0;
for(int i=0;i<len; i++)
{
    Console.WriteLine($"Enter number {i} : ");
    array[i]=int.Parse(Console.ReadLine());
}
for(int i = 0; i < len-1; i++)
{
    if (array[i] > 0 && array[i + 1] < 0)
    {
        counter++;
    }
    else if (array[i] < 0 && array[i + 1] > 0)
    {
        counter++;
    }
}
Console.WriteLine($"Pairs with different signs are: {counter} ");
