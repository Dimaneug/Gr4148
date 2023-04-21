// Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Вычисление факториала
long Factor(int n)
{
    long res = 1;
    for (int i = 1; i <= n; i++)
    {
        res *= i;
    }
    return res;
}

// Печать треугольника Паскаля в виде равнобедренного треугольника
void PrintPascalTriangle(int nRow)
{
    for (int i = 0; i < nRow; i++)
    {
        for (int k = 0; k < nRow-i; k++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Factor(i)/(Factor(j)*Factor(i-j)));
        }
        Console.WriteLine();
    }
}

int countRow = ReadData("Введите количество строк треугольника Паскаля: ");
PrintPascalTriangle(countRow);