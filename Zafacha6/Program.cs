Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 1)
{
    Console.WriteLine($"{a} -> нет");
}
else
{
    Console.WriteLine($"{a} -> да");
}