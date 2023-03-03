Console.Clear();

Console.Write("Введите день недели числом: ");
int num = int.Parse(Console.ReadLine());

bool result = (num < 1) || (num > 7);

if (result)
{
    Console.WriteLine("Введено не верное число");
}

else
{
    if (num < 6)
    {
        Console.WriteLine($"{num} -> Нет");
    }
    else
    {
        Console.WriteLine($"{num} -> Да");
    }

}
