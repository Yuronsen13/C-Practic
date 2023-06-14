Console.WriteLine("Введите день недели от 1 до 7:");
int numday = int.Parse(Console.ReadLine());
if (numday < 1 || numday > 7)
   Console.WriteLine("Введен неверный номер");
if (numday == 6 || numday == 7) 
   Console.WriteLine("Выходной");
if (numday == 1 || numday == 2 || numday == 3 || numday == 4 || numday == 5) 
   Console.WriteLine("Рабочий");
