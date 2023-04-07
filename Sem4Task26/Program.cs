// Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода результата
void PrintResult(string msg, int res)
{
    Console.WriteLine(msg + res);
}

// Метод подсчёта цифр в числе
int CountDigit(int num) 
{
    int res = 0;
    while (num > 0) {
        res += 1;
        num /= 10;
    }
    return res;
}

int num = ReadData("Введите число: ");
PrintResult("Количество цифр: ", CountDigit(num));
