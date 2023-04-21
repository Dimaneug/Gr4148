// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

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

// Вовращает строку и столбец, содержащие минимальный элемент
int[] FindMinElement(int[,] arr)
{
    int[] posOfMinElement = new int[2];
    int minElement = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (minElement > arr[i,j])
            {
                minElement = arr[i,j];
                posOfMinElement[0] = i;
                posOfMinElement[1] = j;
            }
        }
    }
    return posOfMinElement;
}

// Возвращает массив без указанных строки и столбца
int[,] DeleteRowColumn(int[,] arr, int[] positon)
{
    int[,] newArr = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    int k = 0; 
    int m = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i != positon[0] && j != positon[1])
            {
                newArr[k,m] = arr[i,j];
                m++;
            }
        }
        if (i != positon[0])
            k++;
    }
    return newArr;
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int[,] testArr = Gen2DArray(m, n, 0, 50);
Print2DArray(testArr);
int[] position = FindMinElement(testArr);
int[,] newArr = DeleteRowColumn(testArr, position);
Console.WriteLine();
Print2DArray(newArr);