﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число a = ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите число b = ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите число c = ");
        int c = int.Parse(Console.ReadLine());

        if (a < b)
        {
            if (b < c)
            {
                Console.WriteLine("Max = " + c);
            }
             else 
             {
                Console.WriteLine("Max = " + b);
             } 
                     
        }
        else
        {
            if (a<c)
            {
                Console.WriteLine("Max = " + c);
            }
            else
            {
                Console.WriteLine("Max = " + a);
            }
        }
           
