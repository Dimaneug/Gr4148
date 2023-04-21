// Напишите программу, которая заполнит спирально массив 4 на 4. 

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерация двумерного массива
int[,] Gen2DArraySpirally(int n)
{
    int[,] res = new int[n,n];
    int val = 1;
    int rowStart = 0;
    int rowEnd = n - 1;
    int colStart = 0;
    int colEnd = n - 1;
    while (val <= n*n)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            res[rowStart, i] = val;
            val++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            res[i, colEnd] = val;
            val++;
        }
        colEnd--;

        for (int i = colEnd; i >= colStart; i--)
        {
            res[rowEnd, i] = val;
            val++;
        }
        rowEnd--;

        for (int i = rowEnd; i >= rowStart; i--)
        {
            res[i, colStart] = val;
            val++;
        }
        colStart++;
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

int n = ReadData("Введите размерность массива: ");
int[,] testArr = Gen2DArraySpirally(n);
Print2DArray(testArr);

