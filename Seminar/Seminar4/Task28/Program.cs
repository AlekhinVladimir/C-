// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();

Console.WriteLine("Введите число: ");           
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел = {GetPrdctNums(num)}");


int GetPrdctNums(int number)
{
    int count = 1;
    while (number> 0)
    {
        count*=number;
        number--;
    }
    return count;
}
