// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int SumNumsMN (int m, int n)
{
    if(m == n) return n;
    else return m + SumNumsMN(++m, n);
}

int GetNumber()
{
    Console.WriteLine("Введите число");
    string text = Console.ReadLine()!;

    string[] sentence ={"введите корректное число"};

    if(!int.TryParse(text, out int number))
    {
        Console.WriteLine(sentence[new Random().Next(0, 5)]);
        return GetNumber();
    }

    return number;
}

Console.WriteLine("Поочередно введите первое и конечное значение, \nв промежутке между которым необходимо найти сумму всех чисел");
Console.WriteLine(SumNumsMN(GetNumber(), GetNumber()));
