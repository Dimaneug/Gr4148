// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

int[,] MatrixMultiplication(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(1) != arr2.GetLength(0))
        return new int[,] { { -1 } };
    int[,] newArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                newArr[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return newArr;
}

int k = ReadData("Введите верхнюю границу для генерации: ");
int m = ReadData("Введите m для первого массива: ");
int n = ReadData("Введите n для первого массива: ");
int[,] testArr1 = Gen2DArray(m, n, 1, k);
m = ReadData("Введите m для второго массива: ");
n = ReadData("Введите n для второго массива: ");
int[,] testArr2 = Gen2DArray(m, n, 1, k);
Console.WriteLine("Первый массив:");
Print2DArray(testArr1);
Console.WriteLine();
Console.WriteLine("Второй массив: ");
Print2DArray(testArr2);
Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
Print2DArray(MatrixMultiplication(testArr1, testArr2));
