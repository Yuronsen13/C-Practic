// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите трехзначное чило:");
int num = int.Parse(Console.ReadLine()!);

int SumNumbers (int numbers)
{
    int result = 0;
    while (numbers > 0)
    {
      result = result + numbers %10;
      numbers = numbers / 10;
    }
    return result;
}

int sumnumber = SumNumbers(num);
Console.WriteLine($"Сумма всех цифр в числе {num} равна {sumnumber}");
