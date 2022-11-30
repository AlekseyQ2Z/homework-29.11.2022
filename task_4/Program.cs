Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 0;
while (index + 1 < number)
{
    index = index + 2;
    Console.Write(index);
    if (index + 1 < number)
    {
        Console.Write(", ");
    }
}