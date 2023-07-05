// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами



Console.Write("Введите количество строк массива: ");
double rows = double.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
double columns = double.Parse(Console.ReadLine());

double[,] GetArray(double m, double n, double minValue, double maxValue)
{
    double [,] result = new double[m, n];
    for (double i = 0; i < m; i++)
    {
        for (double j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (double i = 0; i < inArray.GetLength(0); i++)
    {
        for (double j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i ,j]} ");
        }
        Console.WriteLine();
    }
}

double[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);