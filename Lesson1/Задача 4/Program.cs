// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.WriteLine("Введите первое число");
int numa = int.Parse(Console.ReadLine ());
Console.WriteLine("Введите второе число");
int numb = int.Parse(Console.ReadLine ());
Console.WriteLine("Введите третье число");
int numc = int.Parse(Console.ReadLine ());
int max = numa;
if (numb > max) max = numb;
if (numc > max) max = numc;
    Console.WriteLine ($"Максимальное значение {max}");