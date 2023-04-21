// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

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
            res[i, j] = new Random().Next(bot, top);
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

// Возвращает индекс строки с минимальной суммой элементов
int FindRowWithMinSum(int[,] arr)
{
    int minSum = int.MaxValue;
    int row = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++) {sum += arr[i,j];}
        if (sum < minSum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row;
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int k = ReadData("Введите верхнюю границу для генерации: ");
int[,] testArr = Gen2DArray(m, n, 0, k);
Print2DArray(testArr);
Console.WriteLine("Строка с минимальной суммой: " 
                  + (FindRowWithMinSum(testArr)+1));