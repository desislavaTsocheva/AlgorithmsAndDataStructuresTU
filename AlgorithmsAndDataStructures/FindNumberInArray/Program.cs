//Напишете програма за изчисление на първото xn > 100 за редицата xn+1 = 2xn + 10,
//където x0 = 2, а n = 0, 1,...

int[] array=new int[15];
int index = 0;
array[0] = 2;
while (array[index] <= 100)
{
    array[index+1] = 2 * array[index]+10;
    index++;
}
Console.WriteLine($"First number > 100 in the array is: {array[index]}");