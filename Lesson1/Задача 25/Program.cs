// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое чило:");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе чило:");
int number2 = int.Parse(Console.ReadLine()!);

int Degree(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i<= num2; i++)
    {
    result = result * num1;
    }
    return result;
} 

int degree = Degree(number1, number2);
Console.WriteLine($"Первое чило {number1} в степени второго числа {number2} равно {degree}");
