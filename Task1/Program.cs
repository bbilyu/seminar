
Console.Write("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine()); 
Console.Write("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine());
if (num_1 == num_2*num_2 )
{
Console.Write($"Число {num_1} является квадратом числа {num_2} ");
}
else
{
Console.Write($"Число {num_1} не является квадратом числа {num_2} ");
}
