Console.Clear();
Console.Write("Введите пятизначное число: ");
string numStr = Console.ReadLine();

int Num1 = 0;
int Num2 = numStr.Length - 1;

if (Num2 == 4)
{
    while (Num1 < Num2 && Char.IsDigit(numStr[Num1]) && Char.IsDigit(numStr[Num2]))
    {
        if (numStr[Num1] == numStr[Num2])
        {
            Num1++;
            Num2 = Num2 - 1;
        }
        else
        {
            Console.WriteLine($"{numStr} -> нет");
            Num1 = 5;
        }
    }
    if (Num1 == 2) Console.WriteLine($"{numStr} -> да");
}

else Console.WriteLine("Введено не верное значение");