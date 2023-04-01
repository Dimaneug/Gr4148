// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Возвращает словарь со всеми четырёхзначными палиндромами в виде ключей
// со значениями true
Dictionary<int, bool> FillDict()
{
    var fourDigitPalindromes = new Dictionary<int, bool>();
    for (int i = 1; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
            fourDigitPalindromes.Add((i * 1000 + j * 100 + j * 10 + i), true);
    }
    return fourDigitPalindromes;
}

/// Проверяет, является ли пятизначное число палиндромом
bool PalTest(int num)
{
    bool res = false;
    Dictionary<int, bool> fourDigitPalindromes = FillDict();
    num = int.Parse(num.ToString().Remove(2, 1));
    if (fourDigitPalindromes.ContainsKey(num))
        res = true;
    return res;
}

try
{
    int num = ReadData("Введите пятизначное число: ");
    if (9999 < num && 100000 > num)
        Console.WriteLine(PalTest(num) ? "Число является палиндромом" : "Число не является палиндромом");
    else
        Console.WriteLine("Вы ввели не пятизначное число!");
}    
catch
{
    Console.WriteLine("Вы ввели не число!");
}
