using System.Diagnostics.Metrics;

Console.WriteLine("Enter row= ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter col= ");
int col = int.Parse(Console.ReadLine());

int[,] matrix = new int[row, col];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}

//MAIN DIAGONAL
int mainDiagonal = row;
int[] main=new int[mainDiagonal];
for(int i = 0; i < mainDiagonal; i++)
{
    main[i]=matrix[i,i];
}

//SECOND DIAGONAL
int secDiagonal = row;
int[] sec=new int[secDiagonal];
for (int g = 0; g < secDiagonal; g++)
{
    sec[g] = matrix[g, col - 1 - g];
}

//COUNTER i%2!=0;
int counter = 0;
for (int i = 0; i < row; i++)
{
    if (i % 2 != 0)
    {
        for (int j = 0; j < col; j++)
        {
            if (matrix[i, j] < 0)
            {
                counter++;
            }
        }
    }
}

//ARRAY LENGTH
int[] array = new int[mainDiagonal + secDiagonal+counter];

//ADD MAIN DIAGONAL ELEMENTS
int index = 0;

for (int i = 0; i < mainDiagonal; i++)
{
    array[index] = main[i];
    index++;
}

//ADD SECOND DIAGONAL ELEMENTS
for (int i = 0; i < secDiagonal; i++)
{
    array[index] = sec[i];
    index++;
}

//ADD i%2!=0 ELEMENTS
for (int i = 0; i < row; i++)
{
    if (i % 2 != 0)
    {
        for (int j = 0; j < col; j++)
        {
            if (matrix[i, j] < 0)
            {
                array[index] = matrix[i, j];
                index++;
            }
        }
    }
}

//PRINT NEW ARRAY
Console.WriteLine("\nResult array:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
