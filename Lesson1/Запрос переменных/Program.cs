// // Функции: 
// 1. Запроса переменных:
// 2. Создание массива
// 3. Заполнение массива
// 4. Печать массива


// 1. Запрос переменных.
Console.Write("Введите элементы массива через пробел:");
string.elements = Console.ReadLine()!;
int[] baseArray = GetArrayFromString(elements)!;
Console.Write(baseArray);

int[] GetArrayFromString (string stringArray)
{
    string[] nums = stringArray.Split(" ");
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}



// // 2. Создание массива.






// 3. Заполнение массива.
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}


// 4.Печать массива.
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}