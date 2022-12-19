/// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int start, int end)  
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(start, end);
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}]");
}

int CountEvenNumbersArray(int[] collection)
{
    int count = 0;
    foreach (var item in collection)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

int[] threeDigitArray = CreateArrayRndInt(10, 100, 1000);  // Вывод именно трехзначных чисел от 100 до 999

PrintArray(threeDigitArray);
Console.Write($" => {CountEvenNumbersArray(threeDigitArray)}");