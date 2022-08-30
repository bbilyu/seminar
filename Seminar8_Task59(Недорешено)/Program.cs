// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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

int[] FindMinElementMatrix(int[,] matrix)
{
    int minIndexRow = 0;
    int minIndexColum = 0;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minIndexRow = i;
                minIndexColum = j;
            }
        }
    }
    int[] arr = new int[2] { minIndexRow, minIndexColum };
    return arr;
}



int[,] ReduceMatrix(int[,] matrix, int rows, int colums, int[] minIndexRowColum)
{
    int[,] reducematrix = new int[rows - 1, colums - 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == minIndexRowColum[0] &&  i < matrix.GetLength(0)) i++;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == minIndexRowColum[1] &&  j < matrix.GetLength(0)) j++;
            reducematrix[i, j] = matrix[i, j];
        }
    }
    return reducematrix;

}

int[,] array2d = CreateMtrixRndInt(row, colum, 1, 99);

PrintMatrix(array2d);

int[] findMinElementMatrix = FindMinElementMatrix(array2d);

System.Console.WriteLine();

int[,] reduceMatrix = ReduceMatrix(array2d, row, colum, findMinElementMatrix);

PrintMatrix(reduceMatrix);
