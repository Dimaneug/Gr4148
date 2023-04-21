// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерация двумерного массива
int[,] Gen2DArray(int m, int n, int bot, int top)
{
    if (bot > top)
    {
        int buf = bot;
        bot = top;
        top = buf;
    }

    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] += new Random().Next(bot, top);
        }
    }
    return res;
}

// Печать двумерного массива
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SwapTopBottomRows(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        (arr[0,i], arr[arr.GetLength(0)-1, i]) = (arr[arr.GetLength(0)-1, i], arr[0,i]);
    }
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int[,] testArr = Gen2DArray(m, n, 0, 50);
Print2DArray(testArr);
SwapTopBottomRows(testArr);
Print2DArray(testArr);