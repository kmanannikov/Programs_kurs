Console.Clear();
Console.WriteLine("Необходимо ввести два положительных числа");
int m = InputInt("Введите значение m: ");
int n = InputInt("Введите значение n: ");

Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Akkerman(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}