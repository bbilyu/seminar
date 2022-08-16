// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.WriteLine("Введите координаты точки A:");
Console.Write("Введите x: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
Console.Write("Введите x: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y2 = int.Parse(Console.ReadLine());

double Distance(int xc1,int yc1,int xc2,int yc2)
{
    return Math.Round(Math.Sqrt((xc1-xc2)*(xc1-xc2) + (yc1-yc2)*(yc1-yc2)),2,MidpointRounding.ToZero);
}

Console.WriteLine($"A({x1},{y1}); B({x2},{y2}) -> {Distance(x1,y1,x2,y2)} ");

