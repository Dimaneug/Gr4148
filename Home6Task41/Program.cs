// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

using System.Text.RegularExpressions;

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Возвращает строку с заданным кол-вом символов
string ReadString(int n)
{
    Console.WriteLine("Вводите символы: ");
    string? text = Console.ReadLine();
    if (string.IsNullOrEmpty(text))
        return "";
    return text.Substring(0,n);
}

// Считает кол-во положительных чисел в строке 
int CountPosNums(string text)
{
    Regex regex = new Regex(@"\-?\d+");
    MatchCollection matches = regex.Matches(text);
    int count = 0;
    if (matches.Count > 0)
    {
        foreach (Match match in matches)
            if (int.Parse(match.Value) > 0)
                count++;
    }
    return count;
}

int n = ReadData("Введите количество нажатий: ");
string text = ReadString(n);
Console.WriteLine(CountPosNums(text));