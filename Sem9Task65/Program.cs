// Задайте значения M, N и напишите программу, 
// которая выведет все натуральные элементы 
// в промежутке от M до N.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Возвращает строку со всеми натуральными числами из промежутка [m;n]
string RecMN(int m, int n)
{
    if (m > n) return String.Empty;
    return m + " " + RecMN(m+1, n);
}

int m = ReadData("Введите M: ");
int n = ReadData("Введите N: ");
Console.WriteLine((m>n)?RecMN(n,m):RecMN(m,n));

