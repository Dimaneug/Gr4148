// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.

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

// Сортировка подсчётом
void CountSort(int[] arr, int k)
{
    // массив для хранения отсортированного массива
    int[] output = new int[arr.Length];

    // массив для хранения кол-ва повторений чисел
    int[] freq = new int[k + 1];
    for (int i = 0; i < arr.Length; i++)
        freq[arr[i]]++;

    // Вычисляем начальный индекс для каждого целого числа
    int total = 0;
    for (int i = 0; i < k+1; i++)
    {
        int oldCount = freq[i];
        freq[i] = total;
        total += oldCount;
    }

    // Копируем в список выходов, сохраняя порядок входов с одинаковыми ключами
    for (int i = 0; i < arr.Length; i++)
    {
        output[freq[arr[i]]] = arr[i];
        freq[arr[i]] += 1;
    }

    // Копируем список вывода обратно в список ввода
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = output[i];
    }
}

// Метод сортирует по возрастанию все строки массива
void SortArrRows(int[,] arr, int k)
{
    int[] newRow = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newRow[j] = arr[i,j];
        }
        CountSort(newRow, k);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = newRow[j];
        }
    }
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int k = ReadData("Введите верхнюю границу для генерации: ");
int[,] testArr = Gen2DArray(m, n, 0, k);
Print2DArray(testArr);
SortArrRows(testArr, k);
Console.WriteLine();
Print2DArray(testArr);