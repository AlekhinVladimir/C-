﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);

int a1=a/10;
int a2=a1%10;
Console.WriteLine(a2);
