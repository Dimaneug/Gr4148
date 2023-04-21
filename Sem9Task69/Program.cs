// Напишите программу, которая будет принимать два числа a и b.
// Возведите число a в степень b при помощт рекурсии.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Возведение a в степень b рекурсивно
long APowB(int a, int b)
{
    if (b == 1) return a;
    if (b == 0) return 1;
    return (b == 2) 
            ? a * a 
            : APowB(a, (b % 2 == 0) 
                        ? b / 2 
                        : b / 2 + 1) * APowB(a, b / 2);
}

int a = ReadData("Введите a: ");
int b = ReadData("Введите b: ");
Console.WriteLine(APowB(a, b));