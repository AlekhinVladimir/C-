// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.WriteLine("Введите число: ");           
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе = {GetSummNums(num)}");


int GetSummNums(int number)
{
    int count = 0;
    int last = 0;
    int Summ = 0;
    while (number> 0)
    {
        last =number % 10;
        Summ+=last;
        number/=10;
    }
    return Summ;
}