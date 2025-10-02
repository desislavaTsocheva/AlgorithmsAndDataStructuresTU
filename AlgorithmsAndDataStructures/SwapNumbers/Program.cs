//Напишете програма за размяна на стойностите на две променливи (цели числа)
//чрез събиране.

Console.WriteLine("Enter number 1:");
int num1=int.Parse(Console.ReadLine()); //3
Console.WriteLine("Enter number 2:");
int num2=int.Parse(Console.ReadLine()); //4
Console.WriteLine($"Numbers before swap: NUM 1: {num1}, NUM 2: {num2} ");
num1 = num1 * num2; //12
num2=num1/num2; //4=12/4 => num2=3
num1 = num1 / num2;   //12=12/3    num1=4
Console.WriteLine($"Numbers after swap: NUM 1: {num1}, NUM 2: {num2} ");

