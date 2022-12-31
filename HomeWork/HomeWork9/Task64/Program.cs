// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""



Console.Clear();
void PrintNumMN (int m, int n)
{
    if(m == n) Console.WriteLine(n);
    else
    {
        Console.Write(m + ", ");
        PrintNumMN(++m, n);
    }
}

int GetNumber()
{
    Console.WriteLine("Введите число");
    string text = Console.ReadLine();

    string[] sentence ={"Введите корректное число!"};

    if(!int.TryParse(text, out int number))
    {
        Console.WriteLine(sentence[new Random().Next(0, 5)]);
        return GetNumber();
    }

    return number;
}

Console.WriteLine("Поочередно введите числа, в промежутке которых необходимо вывести все натуральные числа");
PrintNumMN(GetNumber(), GetNumber());

