Console.Clear();
Console.WriteLine("Введите размер массива");

int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] > max)
    {
        max = numbers[x];
    }
    if (numbers[x] < min)
    {
        min = numbers[x];
    }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"{max} - {min} = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}