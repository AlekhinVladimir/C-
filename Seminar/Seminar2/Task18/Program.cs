// Задача 18:
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int A = int.Parse(Console.ReadLine()!);

if (A==1) Console.WriteLine("x>0 и y>0");
if (A==2) Console.WriteLine("x<0 и y>0");
if (A==3) Console.WriteLine("x<0 и y<0");
if (A==4) Console.WriteLine("x>0 и y<0");
if (A>4||A<=0 ) Console.WriteLine("Введие корректный номер четверти!");
