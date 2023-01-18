System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    System.Console.WriteLine($"Максимальное число равно: {a}");
    System.Console.WriteLine($"Минимальное число равно: {b}");
}
else
{
    System.Console.WriteLine($"Максимаьное число равно: {b}");
    System.Console.WriteLine($"Минимальное число равно: {a}");
}