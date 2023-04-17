// Вывести N чисел Фибоначчи без рекурсии

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Выводит n чисел Фибоначчи
void PrintFibonacchi(int n)
{
    if (n < 1) return;
    int a = 0;
    int b = 1;
    Console.Write(a + " ");
    if (n == 1)
    {
        Console.WriteLine();
        return;
    }
    Console.Write(b + " ");
    if (n == 2)
    {
        Console.WriteLine();
        return;
    }
    for (int i = 3; i <= n; i++)
    {
        (a, b) = (b, a + b);
        Console.Write(b + " ");
    }
    Console.WriteLine();
}

int n = ReadData("Введите N: ");
PrintFibonacchi(n);