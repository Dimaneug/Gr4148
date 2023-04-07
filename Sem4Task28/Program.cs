// Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N

using System.Numerics;
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

// Метод вычисления факториала
BigInteger Factorial(int num) 
{
    BigInteger res = 1;
    for (int i =2; i<=num;i++)
        res *= i;
    return res;
}

int num = ReadData("Введите число N: ");
PrintResult("Факториал введённого числа: ", (int)Factorial(num));