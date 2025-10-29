static int PowerNum(int number,int n)
{
    if(n == 0)
    {
        number = 1;
    }
    if (n > 0)
    {
        number=number*PowerNum(number,n-1);
    }
    if (n < 0)
    {
        number=1/PowerNum(number,-n);
    }
    return number;
}

int number = 2;
int n = 3;
Console.WriteLine(PowerNum(number, n));    
