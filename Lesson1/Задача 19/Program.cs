// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите 5-значное число:");
int num1 = int.Parse(Console.ReadLine()!);
// if (num1 < 10000 && num1 > 99999)
if (num1 < 10000)
{
    Console.WriteLine("Введите верное число");
}

else if (num1 > 99999)
{
    Console.WriteLine("Введите верное число");
}

else
{
    int num2 = num1;
    int num3 = 0;
    int index2 = 10000;
    while (num2 != 0)
    {
        num3 = num3 + (num2 % 10) * index2;
        num2 = num2 / 10;
        index2 = index2 / 10;
    }
    if (num3 == num1)
    {
        Console.Write($"число полиндром");
    }
    else
    {
        Console.Write($"число не полиндром");
    }
}