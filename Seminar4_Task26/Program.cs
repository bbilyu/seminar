// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());


int NumbersOfDigit(int num)
{
    int count = 0;
    if (num == 0) return 1;
    while (num > 0)
    {
        count++;
        num = num / 10;
    }
    return count;
}
int result  = NumbersOfDigit(number);
Console.WriteLine($"Количесивр цифр в числе {number}: {result}");