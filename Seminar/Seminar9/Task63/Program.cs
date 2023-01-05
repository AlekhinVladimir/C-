// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


//ВАРИАНТ ВЫВОДА ЧЕРЕЗ СТРОЧНЫЙ МАССИВ
string LineNumbers(int n)
{
return (n>=2) ? LineNumbers(n-1) + $" {n}" : "1";

// if(n>=2)                 расписана строка 10
// {
// return LineNumbers(n-1) + $" {n}";
// }
// else
// {
// return "1";
// }

}
Console.WriteLine(LineNumbers(10));




//ВАРИАНТ ВЫВОДА VOID
void LineNumbers2(int n)
{
if(n != 1) LineNumbers2(n - 1);
Console.Write($"{n} ");
}
LineNumbers2(5);