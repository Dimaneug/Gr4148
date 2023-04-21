// Почитать сумму цифр числа рекурсивно

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Сумма цифр числа рекурсивно
int SumOfDigits(int num)
{
    return (num > 0) ? num % 10 + SumOfDigits(num / 10) : 0;
}

int num = ReadData("Введите число: ");
Console.WriteLine("Сумма цифр: " + SumOfDigits(num));
