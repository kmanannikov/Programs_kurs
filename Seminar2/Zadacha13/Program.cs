Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int a = num;

bool result = (num < 100);

if (result)
{
    Console.WriteLine("Третьей цифры нет");
}

else
{
    while (a > 999)
    {
       a = a / 10;
    }
    Console.WriteLine($"{num} -> {a % 10}");
}
