
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()); 
int x = n * (-1);
Console.Write($"{n}->'");
while (x <= n)
{
    Console.Write($"{x} ");
    x++;
}
Console.Write("'");
