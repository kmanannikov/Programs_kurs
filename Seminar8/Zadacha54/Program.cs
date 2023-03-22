Console.Clear();
Console.WriteLine("введите количество строк в массиве");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов в массиве");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[lines, colums];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int x = 0; x < numbers.GetLength(1) - 1; x++)
        {
            if (numbers[i, x] < numbers[i, x + 1])
            {
                int temp = 0;
                temp = numbers[i, x];
                numbers[i, x] = numbers[i, x + 1];
                numbers[i, x + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными по убыванию строками");
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}