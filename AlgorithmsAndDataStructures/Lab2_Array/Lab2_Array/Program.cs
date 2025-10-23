int[] arr=new int[] {2,4,7,8,4,7,3,1};

int min = arr[0];
int max = arr[0];
int counter = 0;

for(int i=0; i<arr.Length; i++)
{
    if (min > arr[i])
    {
        min = arr[i];
    }
    if (max < arr[i])
    {
        max = arr[i];
    }
}

for(int i=0;i<arr.Length; i++)
{
    if (arr[i] % 2 != 0 && arr[i] != min & arr[i] != max)
    {
        counter++;
    }
}

int[] arr2 = new int[counter + 2];
arr2[0] = min;
int index = 1;
for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 != 0 && arr[i] != min & arr[i]!=max)
    {
        
        arr2[index] = arr[i];
        index++;
    }
    
}
arr2[index] = max;

for(int i = 0; i < arr2.Length; i++)
{
    Console.Write(arr2[i]+" ");
}
