Console.Clear();
int Num = 8;
int[] array = new int[Num];

for (int i = 0; i < Num; i++)
{
    array[i] = new Random().Next(Num + 1);
    Console.Write($"{array[i]}, ");
}