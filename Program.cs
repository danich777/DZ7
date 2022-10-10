// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 7 -2 -85
// 1 -3 8 -9
// 8 7 -7 9

// Console.WriteLine("Введите количество строк (m): ");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов (n): ");
// int n = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(m, n, -99, 99);
// PrintArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2

// int[,] array = GetArray(4, 4, 0, 9);
// PrintArray(array);

// Console.WriteLine("Введите номер строки (i): ");
// int row = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите номер столбца (j): ");
// int column = int.Parse(Console.ReadLine()!);

// if ((row <= 4) && (column <= 4))
// {
//     Console.WriteLine($"Значение {array[row, column]} ");
// }
// else
// {
//     Console.WriteLine("Такого числа в массиве нет");
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = GetArray(3, 4, 0, 9);
PrintArray(array);

double[] result = new double[4];

for (int j = 0; j < 4; j++)
{
    double summ = 0;
    for (int i = 0; i < 3; i++)
    {
        summ += array[i, j];
        result[j] = summ / 3;
    }
}

Console.WriteLine($"Среднее арифметическое каждого столбца {String.Join("; ", result)}");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}