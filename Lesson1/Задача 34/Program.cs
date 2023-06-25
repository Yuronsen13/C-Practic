// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] startArray = GetArray(4, 100, 1000);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int Dest(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2  == 0)
            {
                count++;
            }
    }
    return count;
}
// int Dest(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

Console.WriteLine(String.Join(" ", startArray));
int countpoz = Dest(startArray);
Console.WriteLine($"количество четных чисел = {countpoz}");