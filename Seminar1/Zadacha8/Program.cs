int i = 1;
bool not = true;
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write($"{a} -> ");
while (i <= a)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел");
}