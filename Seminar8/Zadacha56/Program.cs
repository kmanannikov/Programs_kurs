Console.Clear();
int array = 4;
int[,] numbers = new int[array, array];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int min = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];        
    }
    if (sum < min)
    {
        min = sum;
        indexLine++;
    }
}

Console.WriteLine("номер строки с наименьшей суммой элементов: " + (indexLine) + ", сумма элементов строки = " + (min));

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