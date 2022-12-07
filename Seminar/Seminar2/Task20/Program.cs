// Задача 20:
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введиту координату x точки A = ");
int xA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введиту координату y точки A = ");
int yA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введиту координату x точки B = ");
int xB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введиту координату y точки B = ");
int yB = int.Parse(Console.ReadLine()!);

double hypotenusa = (double)Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA));
Console.WriteLine("Расстояние между точками = " + Math.Round(hypotenusa, 2));
