// Напишите программу, которая принимает на вход число
// (А) и выдаёт сумму чисел от 1 до А

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

// Вычисление суммы циклом
long SumSimple(int numA)
{
    long sum = 0;
    for (int i = 1; i <= numA; i++)
        sum += i;
    return sum;
}

// Вычисление суммы формулой Гаусса
long SumGauss(int numA)
{
    return ((1 + (long)numA) * (long)numA / 2);
}

int numberA = ReadData("Введите число А: ");

DateTime d1 = DateTime.Now;
long res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
long res2 = SumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до А(простой метод): ", (int)res1);
PrintResult("Сумма чисел от 1 до А(формула Гаусса): ", (int)res2);
