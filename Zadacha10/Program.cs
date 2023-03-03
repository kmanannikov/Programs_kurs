Console.Clear();

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

//int b = ((num / 10) % 10);

bool result = (num < 100) || (num > 999);

if (result)
{
    Console.WriteLine("Введено не верное число");
}

else
{
    Console.WriteLine($"{num} -> {((num / 10) % 10)}");
}
