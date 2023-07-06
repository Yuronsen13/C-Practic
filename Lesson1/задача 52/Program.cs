// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] ResultArray(double[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[j] += Math.Round(array[i, j] / array.GetLength(0), 2);
        }
    }
    return result;
}


int rows = InputNum("Введите количество строк массива: ");

int columns = InputNum("Введите количество стобцов массива: ");

double[,] array = GetArray(rows, columns, 0, 15);
PrintArray(array);

double[] AverageColumns = ResultArray(array);
Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ", AverageColumns)}");
