// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.
Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Точка принадлежит 1 четверти");
// else if (x > 0 && y < 0) Console.WriteLine("Точка принадлежит 4 четверти");
// else if (x < 0 && y > 0) Console.WriteLine("Точка принадлежит 2 четверти");
// else if (x < 0 && y < 0) Console.WriteLine("Точка принадлежит 3 четверти");
// else Console.WriteLine("Введены некоректные координаты");

// int quarter = 0;
// if (x >0 && y > 0) quarter = 1;
// else if (x >0 && y < 0) quarter = 4;
// else if (x <0 && y > 0) quarter = 2;
// else if (x <0 && y < 0) quarter = 3;
// if (x != 0 && y != 0) Console.WriteLine($"{quarter} четверть");
// else Console.WriteLine("Введены некоректные координаты");

string GetQuarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Точка принадлежит 1 четверти";
    if (xc > 0 && yc < 0) return "Точка принадлежит 4 четверти";
    if (xc < 0 && yc > 0) return "Точка принадлежит 2 четверти";
    if (xc < 0 && yc < 0) return "Точка принадлежит 3 четверти";
    return "Введены некоректные координаты";
}

string result = GetQuarter(x,y);
Console.WriteLine(result);