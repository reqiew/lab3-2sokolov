using System;

Console.WriteLine("Введите накопления студента");
double s = double.Parse(Console.ReadLine());
Console.WriteLine("Введите стипендию студента");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите траты студента");
double b = double.Parse(Console.ReadLine());
double c = 0;
int v = 0;
for (double i = 0; c >= 0; i++)
{
    c = (s + a) - b;
    b += b / 100 * 3;
    s -= b - a;
    v++;
}
Console.WriteLine($"Студент выживет {v} месяцев");