static int FindNum(int number, int find)
{
    int res=0;
    if(number== 0)
    {
        res = 0;
        return 0; 
    }
    if (number > 0) 
    {
        int digit = number % 10;
        if (digit == find)
        {
            res = 1;
            return res;
        }
    }

    return FindNum(number / 10, find); ;
}
int number = 32;
int find = 2;
Console.WriteLine(FindNum(number,find));
