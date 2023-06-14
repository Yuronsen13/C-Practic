Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine ());
Console.WriteLine ($"Второй символ в числе {(number/10)%10}");