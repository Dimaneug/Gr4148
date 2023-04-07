// Напишите калькулятор с операциями +,-,/,* и возведение в степень

using System.Numerics;
// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

long Sum(int num1, int num2) 
{
    long res = num1 + num2;
    return res;
}

long Sub(int num1, int num2)
{
    long res = num1 - num2;
    return res;
}

double Div(int num1, int num2)
{
    try 
    {
        double res = (double)num1 / (double)num2;
        return res;
    }
    catch(DivideByZeroException) 
    {
        Console.WriteLine("Нельзя делить на ноль!");
        return 0;
    }
}

long Mul(int num1, int num2) 
{
    long res = num1 * num2;
    return res;
}

double Pow(int num1, int num2)
{
    double res = Math.Pow((double)num1, (double)num2);
    return res;
}

void Calculator()
{
    int num1 = ReadData("Введите первое число: ");
    Console.Write("Введите операцию: ");
    char operation = char.Parse(Console.ReadLine()??"0");
    int num2 = ReadData("Введите второе чиcло: ");
    switch (operation)
    {
        case '+': 
            Console.WriteLine(Sum(num1, num2));
            break;
        case '-': 
            Console.WriteLine(Sub(num1, num2));
            break;
        case '/': 
            Console.WriteLine(Div(num1, num2));
            break;
        case '*': 
            Console.WriteLine(Mul(num1, num2));
            break;
        case '^': 
            Console.WriteLine(Pow(num1, num2));
            break;
        default:
            Console.WriteLine("Вы ввели неверную операцию!");
            break;
    }
}

Calculator();