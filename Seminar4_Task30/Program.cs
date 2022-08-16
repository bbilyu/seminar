// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();

Console.Write("Введите колчисетво элементов массива: ");
int element = int.Parse(Console.ReadLine());
int[] arr = new int[element];

void FillArray(int elem, int[] array)
{
    for (int i = 0; i < elem; i++)
    {
        array[i] = new Random().Next(0, 2); 
    }
}

void PrintArray(int elem_2, int[] array_2)
{
    Console.Write($"array = [ ");
    for (int i = 0; i < elem_2; i++)
    {
        Console.Write($"{array_2[i]} ");
    }
    Console.Write($"]");
}


FillArray(element, arr);
PrintArray(element, arr);


