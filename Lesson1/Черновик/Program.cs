// Пример с семинара (Основа нового кода!)
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



//Задача 32
int[] GetRandomArray(int size, int minValue, int maxValue)
		{
			int[] result = new int[size];
			for (int i = 0; i < size; i++)
			{
				result[i] = new Random().Next(minValue, maxValue + 1);
			}
			return result;
		}
		int[] InvertArray(int[] array)
		{			
			int[] result = new int[array.Length];
			for (int j = 0; j < array.Length; j++)
			{
				result[j] = array[j] * (-1);
			}
			return result;
		}
		int[] OldArray = GetRandomArray(12, -9, 9); 
		int[] NewArray = InvertArray(OldArray);
		Console.WriteLine(String.Join(", ", OldArray));
		Console.WriteLine(String.Join(", ", NewArray));



//         **Задача 33:**Задайте массив.Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.

// 4; массив[6, 7, 19, 345, 3]->нет
// 3; массив[6, 7, 19, 345, 3]->да*/

int[] GetUserArray(int size)
		{
			int[] result = new int[size];
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine($"Insert {i} element");
				result[i] = int.Parse(Console.ReadLine());
			}
			return result;
		}
		bool DightInArray(int[] array, int Dight)
		{			
			bool rez = false;
			foreach (int j in array)
			{
				if (j == Dight) {rez = true;}
			}
			return rez;
		}
		Console.WriteLine("Insert quant array");
		int UserSize = int.Parse(Console.ReadLine());
		int[] UserArray = GetUserArray(UserSize);
		Console.WriteLine("Insert dight");
		int UserDight = int.Parse(Console.ReadLine());
		bool UserResult = DightInArray(UserArray, UserDight);
		Console.WriteLine(UserResult);

// второе решение задачи.







/***Задача 35:**Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2]-> 0

[10, 11, 12, 13, 14]-> 5*/






/**Задача 37:**Найдите произведение пар чисел в одномерном массиве.
 Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
 Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6]-> 36 21
