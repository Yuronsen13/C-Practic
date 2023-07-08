﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] CreateArray(int rows, int cols)
{
    return new int[rows, cols];
}

void FillArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int[] SumItemsCols(int[,] array, int rows)
{
    int[] result = new int[rows];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        result[k] = sum;
        k++;
    }
    return result;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int MinRow(int[] array)
{
    int minSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minSum]) minSum = i;
    }
    return minSum;
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимальное значение диапазона: ");

int[,] myArray = CreateArray(rows, columns);
FillArray(myArray, minValue, maxValue);
PrintArray(myArray);
Console.WriteLine();

int[] mySumArray = SumItemsCols(myArray, rows);
PrintArray(mySumArray);
Console.WriteLine();


int minRowSum = MinRow(mySumArray);
Console.WriteLine($"Номер строки с наименьшей суммой элементов --> {minRowSum+1}, индекс строки {minRowSum}");

