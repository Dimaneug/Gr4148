// Преобразовать десятичное число в двоичное

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Перевод из десятичной в двоичную
string ConvertToBin(int num)
{
    string res = "";
    while (num>0) 
    {
        res = (num%2).ToString() + res;
        num /= 2;
    }
    return res;
}

int num = ReadData("Введите число: ");
Console.WriteLine(ConvertToBin(num));

