// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
// нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

int SummElemetts (int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        {
            result += array[i];
        }
    }
    return result;
}            
            

 int[] startArray = GetArray(11, 0, 10);
 PrintArray(startArray);
 int summElements = SummElemetts(startArray);
 Console.WriteLine($"Сумма элементов стоящих на нечетной позиции = {summElements}");
