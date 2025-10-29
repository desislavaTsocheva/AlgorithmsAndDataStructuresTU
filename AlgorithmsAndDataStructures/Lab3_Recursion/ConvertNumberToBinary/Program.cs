static string ConvertToBinary(int num)
{
    if (num == 0)
    {
        Console.Write("0");
    }
    if (num > 1)
    {
        return ConvertToBinary(num / 2) + (num % 2); ;
    }
    return num.ToString();
}


Console.WriteLine("Enter natural number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Natural number: " + number);
Console.WriteLine("Binary number: " + ConvertToBinary(number));
