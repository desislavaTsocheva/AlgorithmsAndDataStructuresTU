int m = int.Parse(Console.ReadLine());
int[,] d = new int[m, m];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        do
        {
            d[i, j] = int.Parse(Console.ReadLine());
        } while (d[i, j] < -999 || d[i, j] > 999);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(d[i, j] + " ");
    }
    Console.WriteLine();
}

int[] counterRow = new int[m];
int[] counterColl = new int[m];
for(int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (d[i, j] < 0) { counterRow[i]++; }
    }
}

for(int j = 0; j < m; j++)
{
    for (int i = 0; i < m; ++i)
    {
        if (d[i, j] < 0) { counterColl[j]++; }
    }
}

for(int i = 0;i < m; i++)
{
    Console.WriteLine("Row neg: " + counterRow[i]);
}

for(int j = 0;j < m; j++)
{
    Console.WriteLine("Coll neg: " + counterColl[j]);
}

int min_row = counterRow[0];
int min_row_index = 0;
for (int i = 1; i < m; i++)
{
    if (counterRow[i] < min_row)
    {
        min_row = counterRow[i];
        min_row_index = i;
    }
}

int min_column = counterColl[0];
int min_column_index = 0;
for (int j = 1; j < m; j++)
{
    if (counterColl[j] < min_column)
    {
        min_column = counterColl[j];
        min_column_index = j;
    }
}

Console.WriteLine("min row: "+min_row_index);
Console.WriteLine("min coll: "+min_column_index);