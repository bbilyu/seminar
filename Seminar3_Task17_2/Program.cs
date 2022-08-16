// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
Console.Clear();
Console.Write("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());

string Coordinat(int number)
{
    if (number == 1) return "Диапазон возможных координат X > и y > 0";
    if (number == 2) return "Диапазон возможных координат X < и y > 0";
    if (number == 3) return "Диапазон возможных координат X < и y < 0";
    if (number == 4) return "Диапазон возможных координат X > и y < 0";
    return "Введен некорректный номер четверти";
}

string result = Coordinat(num);
Console.WriteLine(result);