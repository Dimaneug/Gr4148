// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

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

int N = ReadData("Введите N: ");
Console.WriteLine(LineGen(N, 1));
Console.WriteLine(LineGen(N, 2));