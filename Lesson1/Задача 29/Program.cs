// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите массив из 8 элементов");
int [] array = new int [8];

void FillArray (int[]array);
{
    Random r
    for (int i = 0; i <= array.Length; i++)
    {
    array [i] = new Randome().Next(1, 100);
    }
}

void PrintArray (int[] array);
{
    for (int i = 0; i <= array.Length; i++)
    {
        Console.WriteLine(array [i] + " , ");
    }
}

FillArray(array);
PrintArray(array);
