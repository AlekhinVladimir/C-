// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Вариант подходит как для цифр так и букв.

Console.WriteLine("Введите пятизначное число:  ");
String number = Console.ReadLine()!;

void Check(string number)
{
    if (number[0] == number[4] | number[1] == number[3]) Console.WriteLine($"Это число: {number} - палиндром.");
    else Console.WriteLine($"Это число: {number} - не палиндром.");
}
if (number!.Length == 5) Check(number);
else Console.WriteLine($"Введите корректное число!");

