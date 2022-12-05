// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("(Это выходной день.) -> да");
}
else
 if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("Эта цифра не подходит условиям ввода. ");
}
else Console.WriteLine("(Это не выходной день.) -> нет");
