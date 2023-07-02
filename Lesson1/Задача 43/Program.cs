// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



// // 1. Способ более простой без функции.

// Console.WriteLine("Введите переменную b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;

// Console.Write($"Точка пересечения двух прямых: [{x},{y}]");


// 2. Способ с использованием функции.

double EnterNums(string message)
{
    Console.WriteLine(message);
    return double.Parse(Console.ReadLine());
}

double[] CrossPoint(double b1, double b2, double k1, double k2)
{
    double resultX = (b2 - b1) / (k1 - k2);
    double resultY = k1 * resultX + b1;
    double[] array = new double[2];
    array[0] = resultX;
    array[1] = resultY;
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double number1 = EnterNums("Введите значение b1: ");
double number2 = EnterNums("Введите значение b2: ");
double number3 = EnterNums("Введите значение k1: ");
double number4 = EnterNums("Введите значение k2: ");

double[] result = CrossPoint(number1, number2, number3, number4);
PrintArray(result);