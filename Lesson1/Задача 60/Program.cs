﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int EnterNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int rows, int cols, int cols2)
{
    return new int[rows, cols, cols2];
}

void Fill3DArray(int[,,] array)
{
    int m = 10;
    int ind = 1;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = m;
                m = m + ind;
            }

}

void MixArray(int[,,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int l = rnd.Next(0, array.GetLength(1));
                int m = rnd.Next(0, array.GetLength(2));
                int n = rnd.Next(0, array.GetLength(0));


                if (array[i, j, k] == array[n, l, m]) continue;
                else
                    (array[i, j, k], array[n, l, m]) = (array[n, l, m], array[i, j, k]);
            }
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");

            Console.WriteLine();
        }
}


int maxItems = 89;
int rows = EnterNum("Введите количество строк: ");
int columns = EnterNum("Введите количество столбцов: ");
int columns2 = EnterNum("Введите количество столбцов2: ");


int[,,] my3DArray = Create3DArray(rows, columns, columns2);
Fill3DArray(my3DArray);

if (rows * columns * columns2 > maxItems) Console.WriteLine("Невозможно заполнить массив неповторяющимися двузначныи числами! Элементов в массиве больше!");
else
{
    MixArray(my3DArray);
    Print3DArray(my3DArray);
}


