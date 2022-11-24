void FillArray(int[] collaction)
{
    int length = collaction.Length;
    int index = 0;
    while (index < length)
    {
        collaction[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collaction, int find)
{
    int count = collaction.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collaction[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 44);
Console.WriteLine(pos);
