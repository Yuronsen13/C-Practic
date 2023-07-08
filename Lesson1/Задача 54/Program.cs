// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int EnterNum(string message)
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

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    (array[i, k], array[i, k + 1]) = (array[i, k + 1], array[i, k]);
                }
            }
}


int rows = EnterNum("Введите количество строк: ");
int columns = EnterNum("Введите количество столбцов: ");
int minValue = EnterNum("Введите минимальное значение диапазона: ");
int maxValue = EnterNum("Введите максимальное значение диапазона: ");

int[,] myArray = CreateArray(rows, columns);
FillArray(myArray, minValue, maxValue);
PrintArray(myArray);
Console.WriteLine();

SortArray(myArray);
PrintArray(myArray);
