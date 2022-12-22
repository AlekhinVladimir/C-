// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[,] GetArray(int m, int n, int start, int end)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(start, end);
        }
    }
    return array;
}


int[,] ReplaceElemEvenIndexSquaring(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j % 2 == 0) array[i, j] *= array[i, j];
            }
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


Console.Write("Input rows array: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Input columns array: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Input start rnd: ");
int start = int.Parse(Console.ReadLine()!);

Console.Write("Input end rnd: ");
int end = int.Parse(Console.ReadLine()!);


int[,] array = GetArray(rows, columns, start, end);

PrintArray(array);
Console.WriteLine();
PrintArray(ReplaceElemEvenIndexSquaring(array));
