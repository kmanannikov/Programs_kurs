Console.Clear();
Console.Write("Введите любое число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (Num != 0)
{
    result += Num % 10;
    Num /= 10;
}

Console.WriteLine($"Сумма цифр в числе -> {result}");
