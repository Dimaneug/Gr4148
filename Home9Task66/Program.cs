// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Возвращает сумму натуральных чисел из промежутка [m;n]
int RecSumMN(int m, int n)
{
    return (m<=n)?m+RecSumMN(m+1,n):0;
}

int m = ReadData("Введите M: ");
int n = ReadData("Введите N: ");
Console.WriteLine((m>n)?RecSumMN(n,m):RecSumMN(m,n));

