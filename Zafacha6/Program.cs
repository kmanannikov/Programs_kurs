﻿Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine($"{a} -> да");
}
else
{
    Console.WriteLine($"{a} -> нет");
}