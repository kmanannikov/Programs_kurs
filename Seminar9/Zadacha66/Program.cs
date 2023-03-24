Console.Clear();
int m = InputInt("Введите значение M: ");
int n = InputInt("Введите значение N: ");

Console.WriteLine($"M = {m}; N = {n} -> {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}