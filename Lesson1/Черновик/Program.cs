Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

//int number1 = int.Parse(Console.ReadLine());

// int sum = 0;
// for (int i = 1; i <= number; i++)
// {
//     sum = sum + i; //sum += i;
// }

// Console.WriteLine($"Cумма чисел от 1 до {number} = {sum}");

int sumNumbers = SumNumbers(number); // 7
Console.WriteLine($"Cумма чисел от 1 до {number} = {sumNumbers}");

int sumNumbers1 = SumNumbers(12); // 7
Console.WriteLine($"Cумма чисел от 1 до {12} = {sumNumbers1}");

int sumNumbers2 = SumNumbers(45); // 7
Console.WriteLine($"Cумма чисел от 1 до {45} = {sumNumbers2}");

int SumNumbers(int num) // num = number
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        checked // проверка на переполнение типа
        {
            sum = sum + i; //sum += i;
        }
    }

    return sum;
}