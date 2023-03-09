Console.Clear();
Console.Write("Введите число A: ");

int NumA, NumB;

NumA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
NumB = Convert.ToInt32(Console.ReadLine());

int result = NumA;

for (int i = 2; i <= NumB; i++)
{
    result *= NumA;
}

Console.WriteLine($"{NumA}, {NumB} -> {result}");