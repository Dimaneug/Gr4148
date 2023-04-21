// Напишите программу, которая заполнит спирально массив 4 на 4. 

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерация двумерного спиралевидного массива 
void Gen2DArraySpirally(int[,] arr, int count = 1, int val = 1)
{
    int n = arr.GetLength(0);
    for (int j = -1 + count; j < n - count + 1; j++)
        arr[count - 1, j] = val++;
    for (int i = count; i < n - count + 1; i++)
        arr[i, n - count] = val++;
    for (int j = n - count - 1; j > count - 2; j--)
        arr[n - count, j] = val++;
    for (int i = n - count - 1; i > count - 1; i--)
        arr[i, count - 1] = val++;
    if (val <= n*n)
        Gen2DArraySpirally(arr, ++count, val);
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

int n = ReadData("Введите размерность массива: ");
int[,] testArr = new int[n,n];
Gen2DArraySpirally(testArr);
Print2DArray(testArr);

