// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введиту координату x точки A = ");
int xA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введиту координату y точки A = ");
int yA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введиту координату z точки A = ");
int zA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введиту координату x точки B = ");
int xB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введиту координату y точки B = ");
int yB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введиту координату z точки B = ");
int zB = int.Parse(Console.ReadLine()!);

double distance = (double)Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA)+(zB - zA) * (zB - zA));   //d=sqrt(x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2)
Console.WriteLine("Расстояние между точками = " + Math.Round(distance, 2));
