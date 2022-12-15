// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

Console.WriteLine("Введите число: ");           //Введите число: 12345678910
                                                // Unhandled exception. System.OverflowException: Value was either too large or too small for an Int32. at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, ReadOnlySpan`1 value, TypeCode type) at System.Int32.Parse(String s) at Program.<Main>$(String[] args) in F:\GeekBrains\C#\Seminar\Seminar3\Task26\Program.cs:line 9
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Количество цифр в числе = {GetAmtNums(num)}");


int GetAmtNums(int number)
{
    int count = 0;
    while (number> 0)
    {
        number=number/ 10;
        count++;
    }
    return count;
}