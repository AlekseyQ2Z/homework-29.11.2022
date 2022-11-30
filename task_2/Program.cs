Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine("Первое число больше");
    }
}
else if (number2 > number3)
{
    Console.WriteLine("Второе число больше");
}
else
{
    Console.WriteLine("Третье число больше");
}