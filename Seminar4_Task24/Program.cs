// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.Write("Введите число A: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;

int SumNumbers(int a)
{
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine($"Сумма чисел от 1 до {num}: {Sum(num)}");