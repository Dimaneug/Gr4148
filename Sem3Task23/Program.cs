// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерирует строку с N числами в pow степени
string LineGen(int N, int pow)
{
    string res = "";
    for (int i = 1; i <= N; i++)
        res += Math.Pow(i, pow) + " ";
    return res;
}

// Печатает числа в виде таблицы
void PrintTable(string line1, string line2)
{
    // Вспомогательная функция для печати горизонтальной линии
    void PrintHorizontalLine(int len)
    {
        Console.Write("-");
        for (int i = 0; i < len; i++)
            Console.Write("----");
        Console.Write("\n");
    }

    string[] nums1 = line1.Remove(line1.Length-1,1).Split(" ");
    string[] nums2 = line2.Remove(line2.Length-1,1).Split(" ");
    PrintHorizontalLine(nums1.Length);
    Console.Write("|");
    foreach (var num in nums1)
    {
        Console.Write("{0,3}|", num);
    }
    Console.Write("\n");
    PrintHorizontalLine(nums1.Length);
    Console.Write("|");
    foreach (var num in nums2)
    {
        Console.Write("{0,3}|", num);
    }
    Console.Write("\n");
    PrintHorizontalLine(nums1.Length);
}

int N = ReadData("Введите N: ");
string line1 = LineGen(N, 1);
string line2 = LineGen(N, 2);
PrintTable(line1, line2);
