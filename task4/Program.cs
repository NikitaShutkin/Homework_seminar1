Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine($"Максимальное число {num1}");
    }

}
else if (num2 > num3)
{
    Console.WriteLine($"Максимальное число {num2}");
}
else
{
    Console.WriteLine($"Максимальное число {num3}");
}