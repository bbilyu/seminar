// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.Clear();
while (true)
{
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());
    if (n > 0)
    {
        Console.WriteLine("  --------");
        Console.WriteLine("  x | x**2 ");
        Console.WriteLine("  --------");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i,3} | {i * i,4}");
        }
        Console.WriteLine("________");
        break;
    }
    else
    {
        Console.WriteLine("Введите положительное N");
        continue;
    }
}

