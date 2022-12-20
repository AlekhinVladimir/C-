// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void CountGreaterThen0 (string[] numbers)
{
    int count = 0;
    foreach (var digit in numbers)
    {
        if (int.Parse(digit) > 0) count++;
    }
    Console.WriteLine($"Чисел больше 0 -> {count}");
}

Console.Write("Введите числа через пробел или запятую: ");
string[] array = (Console.ReadLine()!).Split(' ',',');
CountGreaterThen0(array);