Console.Clear();
Console.WriteLine("Введите размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[sizeArray, sizeArray];

int num = 1;
int i = 0;
int j = 0;

while (num <= sizeArray * sizeArray)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < sizeArray - 1)
        ++j;
    else if (i < j && i + j >= sizeArray - 1)
        ++i;
    else if (i >= j && i + j > sizeArray - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

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