// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int fact = 1;

int FactNumber(int num)
{
    for (int i = 1; i <= num; i++)
    {
        fact = fact * i;
    }
    return fact;
}

int result = FactNumber(n);
Console.WriteLine($"{n} -> {result}");