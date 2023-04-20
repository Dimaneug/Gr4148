// Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру 
// разного цвета(цветов всего 16)


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерация двумерного массива
double[,] Gen2DArray(int m, int n, int bot, int top)
{
    if (bot > top)
    {
        int buf = bot;
        bot = top;
        top = buf;
    }

    double[,] res = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().NextDouble();
            res[i, j] += 1 * new Random().Next(bot, top);
        }
    }
    return res;
}

// Печать двумерного массива
void Print2DArray(double[,] arr, ConsoleColor[] colors)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            PrintNumColor(arr[i, j], colors);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

// Печатает разноцветное вещественное число 
void PrintNumColor(double num, ConsoleColor[] colors)
{
    string num_string = num.ToString();
    char[] digits = new char[num_string.Length];
    digits = num_string.ToCharArray();
    Random random = new Random();
    ConsoleColor color = colors[random.Next(0, colors.Length)];
    foreach (char digit in digits)
    {
        while (color == Console.ForegroundColor || color == Console.BackgroundColor)
            color = colors[random.Next(0, colors.Length)];
        Console.ForegroundColor = color;
        Console.Write(digit);
    }

}

ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
double[,] testArr = Gen2DArray(m, n, 0, 50);
Print2DArray(testArr, colors);