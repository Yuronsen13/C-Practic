// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



double[] VeschArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble()*100, 2);
    }
    return result;
}

double MaxArray(double[] array)
{
    double max = array[0];
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinArray(double[] array)
{
    double min = array[0];
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double[] array = VeschArray(5, 0, 100);
PrintArray(array);
Console.WriteLine();
double maxValue = MaxArray(array);
Console.WriteLine($"max = {maxValue}");
double minValue = MinArray(array);
Console.WriteLine($"min = {minValue}");
