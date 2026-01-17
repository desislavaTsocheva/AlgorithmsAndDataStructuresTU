int[,] matrix = {
            { 12, 24, 36, 48 },
            { 60, 15, 25, 72 },
            { 84, 35, 45, 96 },
            { 10, 20, 30, 40 }
        };

int[] arr = new int [25];
int index = 0;
for(int i = 0; i < matrix.GetLength(0); i++)
{
    arr[index]=matrix[0,i];
    index++;
}

for(int i = 1; i < matrix.GetLength(0); i++)
{
    arr [index]=matrix[i,3];
    index++;
}

for(int i=2; i<=0; i++)
{
    arr [index]=matrix[i,3];
    index++;
}

for(int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]+" ");
}
Console.WriteLine();