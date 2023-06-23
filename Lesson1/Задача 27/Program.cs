// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите любое число:");
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


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int[] SumPosNeg(int[] array)
{
    int[] result = new int[2];
    foreach (int el in array)//array = [1, 2, 3, 4, -5, 1, -3] el = array[i]
    {
        //int a = el > 0 ? el : 0;
        //result[0] += a;
        result[0] += el > 0 ? el : 0;//ps += -5 > 0? 2 : 0;
        /*
        if(el > 0)
            result[0] += el
        else
            resuit[0] += 0
        */
        result[1] += el < 0 ? el : 0;
    }
    return result;
}
// for (int i = 0; i < array.Length; i++)
// {
//     int el = array[i]
//     if (el > 0)
//         positiveSum += el;
//     else
//         positiveSum += 0;
//     if (el < 0)
//         negativeSum += el;
//     else
//         negativeSum += 0;
// }
Console.Clear();
int[] array = GetRandomArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));
int[] r = SumPosNeg(array);
Console.WriteLine($"Positive sum = {r[0]}, negative sum = {r[1]} ");
Console.WriteLine($"[ {String.Join(", ", array)} ]");