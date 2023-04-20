// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// * Дополнительно диагональ выделить разным цветом.

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
void Print2DArray(int[,] arr, ConsoleColor[] colors)
{
    ConsoleColor defaultColor = Console.ForegroundColor;
    Random random = new Random();
    ConsoleColor[] diag_colors = new ConsoleColor[arr.GetLength(0) + arr.GetLength(1) - 1];
    for (int i = 0; i < diag_colors.Length; i++)
    {
        diag_colors[i] = colors[random.Next(0, colors.Length)];
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int diag_index = i - j + arr.GetLength(1) - 1;
            Console.ForegroundColor = diag_colors[diag_index];
            Console.Write(arr[i,j]+"\t");
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = defaultColor;
}

// Метод возвращает с
double[] GetArithMeanOfColumns(int[,] arr)
{
    double[] sum = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum[j] += (double) arr[i, j];
        }
    }
    for (int i = 0; i < sum.Length; i++)
    {
        sum[i] = sum[i] / arr.GetLength(1);
    }
    return sum;
}

// Метод вывода массива в консоль
void Print1DArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write(arr[i] + ", ");
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int [,] testArr = Gen2DArray(m,n,0,50);
Print2DArray(testArr, colors);
double[] arithMean = GetArithMeanOfColumns(testArr);
Console.WriteLine("Среднее арифметическое столбцов:");
Print1DArray(arithMean);