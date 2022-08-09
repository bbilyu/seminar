// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число -> {number}");


void MaxDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int numberLast = firstDigit*10 + thirdDigit;
    Console.WriteLine($"{number} -> {numberLast}");
}

MaxDigit(number); 



