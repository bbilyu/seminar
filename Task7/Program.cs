
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine()); 
if (num > 99 && num < 1000)
{
    Console.Write($"Последняя цифра числа {num} = {num % 10}");
}
else 
Console.Write("Число не трёхзеначное");

