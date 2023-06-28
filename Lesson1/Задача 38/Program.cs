// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



double[] VeschArray(int size)
{
    double[] result = new double[size];
    for (double i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble()*100;
    }
    return result;
}

double MaxArray (double[] array)
{
    double max = array[0];
        foreach (double el in array)
        {
            if (array[el] > max) max = array[el];
        }
        return max;
}
            
double MinArray (double[] array)
{
    double min = array[0];
    foreach (double el in array)
        {
            if (array[el] < min) min = array[el];          
        }
        return min;
}    
        
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

double[] array = VeschArray (5);
PrintArray(array);
Console.WriteLine();
double maxValue = MaxArray(array);
Console.WriteLine($"max = {maxValue}");
double minValue = MinArray(array);
Console.WriteLine($"min = {minValue}");
Console.WriteLine($"Разница между максимальным и минимальным = {maxValue - minValue}");

