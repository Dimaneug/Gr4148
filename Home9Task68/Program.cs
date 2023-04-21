// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Функция Аккермана в определении Петер
int AckermannFunction(int n, int m)
{
    if (n == 0) return m+1;
    if (m == 0) return AckermannFunction(n-1, 1);
    return AckermannFunction(n-1, AckermannFunction(n,m-1));
}

int n = ReadData("Введите n: ");
int m = ReadData("Введите m: ");
Console.WriteLine(AckermannFunction(n,m));