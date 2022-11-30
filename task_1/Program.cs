Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write("Первое число ");
    Console.Write(number1);
    Console.Write(" больше");
}
else
{
    Console.Write("Второе число ");
    Console.Write(number2);
    Console.Write(" больше");
}