// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] ReplaceRowsAndColums(int[,] array, int rows, int colums)
{
    int size = array.GetLength(1);

    int[,] arrayTmp = new int[rows, colums];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            arrayTmp[i, j] = array[j, i];
        }
    }
    return arrayTmp;
}

if (row != colum)
{
    Console.WriteLine("Заменить строки на стобцы невозможно!");
}
else
{
    int[,] array2d = CreateMtrixRndInt(row, colum, 1, 99);
    PrintMatrix(array2d);
    System.Console.WriteLine();
    // ReplaceRowsAndColums(array2d, row, colum);
    // PrintMatrix(array2d);
    int[,] replacearr = ReplaceRowsAndColums(array2d, row, colum);
    PrintMatrix(replacearr);
}


void ReplaceRowsAndColums(int[,] array, int rows, int colums)
{
    int size = array.GetLength(1);

    int[,] arrayTmp = new int[rows, colums];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            arrayTmp[i, j] = array[j, i];
        }
    }

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            array[i, j] = arrayTmp[i, j];
        }
    }

}