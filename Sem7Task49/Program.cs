// Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти
// элементы на их квадраты

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

// Возводит в квадрат элементы массива с чётными индексами
void SquareElementsWithEvenIndexes(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)
                arr[i, j] *= arr[i, j];
        }
        Console.WriteLine();
    }
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int[,] testArr = Gen2DArray(m, n, 0, 50);
Print2DArray(testArr);
SquareElementsWithEvenIndexes(testArr);
Print2DArray(testArr);

