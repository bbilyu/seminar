// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных

Console.Clear();

int[,] CreateMtrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

int Rows()
{
    while (true)
    {
        try
        {
            Console.Write("Введите количество строк: ");
            int mTmp = int.Parse(Console.ReadLine());

            if (mTmp <= 0)
            {
                Console.WriteLine("Пожалуйста, введите значение больше нуля!");
                Console.WriteLine();
                continue;
            }
            else return mTmp;
        }
        catch
        {
            Console.WriteLine("Ошибка! Некорректный формат! Повторите попытку!");
            Console.WriteLine();
            continue;
        }
    }
}

int Colums()

{
    while (true)
    {
        try
        {
            Console.Write("Введите количество столбцов: ");
            int nTmp = int.Parse(Console.ReadLine());

            if (nTmp <= 0)
            {
                Console.WriteLine("Пожалуйста, введите значение больше нуля!");
                Console.WriteLine();
                continue;
            }
            else return nTmp;
        }
        catch
        {
            Console.WriteLine("Ошибка! Некорректный формат! Повторите попытку!");
            Console.WriteLine();
            continue;
        }
    }
}

int row = Rows();

int colum = Colums();

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int [,] array2d = CreateMtrixRndInt(row,colum,1,9);

int[] arr = new int[row * colum];

void ConverMatrixToArray(int [,] matrix,int[] array)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i,j];
            k ++;
        }
    }

}

PrintMatrix(array2d);

System.Console.WriteLine();

ConverMatrixToArray(array2d,arr);

PrintArray(arr);

System.Console.WriteLine();

Array.Sort(arr);

PrintArray(arr);

System.Console.WriteLine();


void CountEvenElemet(int[] array)
{
    int tmp = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (tmp == array[i])
        {
            count++;
        }
        else 
        {
            Console.WriteLine($"{tmp} встречается {count} раз");
            tmp = array[i];
            count = 1;
        }
        
    }
    Console.WriteLine($"{tmp} встречается {count} раз");
}

CountEvenElemet(arr);