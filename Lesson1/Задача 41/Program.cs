// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int EnterNums(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int CountNumber(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        int temp = EnterNums($"Введите число {i}: ");
        if (temp > 0)
            count++;
    }
    return count;
}

int number = EnterNums("Введите количество чисел: ");
int res = CountNumber(number);
Console.WriteLine($"Количество чисел больше 0 = {res}");




// int[] count = countArray(nums2);
// Console.WriteLine($"Кол-во элементов > 0: {count}");

// // Console.Write("Введите элементы(через пробел): ");
// // int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// // int count = 0;
 
// // for (int i = 0; i < arr.Length; i++)
// // {
// //     if (arr[i] > 0)
// //     {
// //         count++;
// //     }
// // }
 
// // Console.WriteLine($"Кол-во элементов > 0: {count}");