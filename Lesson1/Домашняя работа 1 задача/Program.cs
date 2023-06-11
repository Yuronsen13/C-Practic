Console.WriteLine("Введите первое значение");
int numa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе значение");
int numb = int.Parse(Console.ReadLine());
int max = numa;
if  (numb > max)
{
    max = numb;
}
else 
{
    max = numa;
}
Console.WriteLine($"Максимальное число {max}");