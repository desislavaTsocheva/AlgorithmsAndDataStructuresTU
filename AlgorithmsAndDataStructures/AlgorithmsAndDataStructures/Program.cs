//Напишете програма за намиране на сумата на цифрите на естествено (цяло
//положително) трицифрено число.

string input;
int sum = 0, number;
Console.WriteLine("Enter normal 3-digit positive number: ");

while (true)
{
    input = Console.ReadLine();
    if (input.Contains(".") || input.Contains(","))
    {
        Console.WriteLine("Enter valid integer number :( ");
    }
    if (int.TryParse(input, out number))
    {
        if ((number > 100 && number < 999))
        {
            break;
        }
        else
        {
            Console.WriteLine("Enter normal 3-digit positive number: ");
        }
    }
}
while (number > 0)
{
    sum += number % 10;
    number /= 10;
}
Console.WriteLine($"Sum is: {sum}");
