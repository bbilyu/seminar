


Console.Clear();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[] ReplacePosElemArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > 0) array[i] = - array[i];
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

int[] arr = CreateArrayRndInt(12, -9, 9);

PrintArray(arr);
PrintArray(ReplacePosElemArray(arr));
