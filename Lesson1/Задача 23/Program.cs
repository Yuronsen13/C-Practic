// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите любое целое число:");
int N = int.Parse(Console.ReadLine()!);
int I = 1;
while (I <= N)
{
Console.Write($" {I} в квадрате = {Math.Pow(I,3)},");
I++;
}