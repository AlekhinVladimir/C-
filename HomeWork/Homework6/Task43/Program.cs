// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("Введите точку b1: ");
double B1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите точку k1: ");
double K1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите точку b2: ");
double B2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите точку k2: ");
double K2 = double.Parse(Console.ReadLine()!);

InterPoint(K1, B1, K2, B2);




void InterPoint(double b1, double k1, double b2, double k2)
{
    double x = (B2 - B1) / (K1 - K2);
    double y = K1 * x + B1;
    if (K1 == K2 && B1 != B2) Console.WriteLine($"Прямые параллельны.");
    else if (K1 == K2 && B1 == B2) Console.WriteLine($"Прямые совпадают.");
    else Console.WriteLine($"Пересечение в точке: ({x};{y})");
}


