// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе

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

// Метод подсчёта суммы цифр в числе
int SumDigit(int num) 
{
    int res = 0;
    while (num > 0) {
        res += num%10;
        num /= 10;
    }
    return res;
}


int num = ReadData("Введите число: ");
PrintResult("Сумма цифр: ", SumDigit(num));
