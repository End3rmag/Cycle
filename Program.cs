using System.Drawing;

Console.WriteLine("Введите значение отрезка (a): ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение отрезка (b): ");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение шага (h): ");
double h = Convert.ToDouble(Console.ReadLine());

if (h <= 0) 
{
    Console.WriteLine("Введено не верное значение");
    return;
}

double maxY = double.MinValue;
double minY = double.MaxValue;

int Point = 0;
int change = 0;

double Ex = Math.Cos(Math.Pow(a,2)) + Math.Pow(Math.Sin(a), 2);

for (double x = a; x <= b; x += h)
{
    double y = Math.Cos(Math.Pow(x,2)) + Math.Pow(Math.Sin(x),2);
    Console.WriteLine($"{y:F2}");
    
    if (y > maxY) maxY = y;
    if (y < minY) minY = y;

    if ((Ex > 0 && y < 0) || (Ex < 0 && y > 0)) 
    {
        change++;
    }
    Ex = y;
    Point++;
}



Console.WriteLine($"Количество точек в таблице: {Point}");
Console.WriteLine($"Максимальное значение функции: {maxY:F2}");
Console.WriteLine($"Минимальне значение функции: {minY:F2}");
Console.WriteLine($"Количество пересечения с осью Х: {change}");