// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

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

int[] CreateFrequencyArr(int[,] arr, int count)
{
    int[] frequencyArr = new int[count];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            frequencyArr[arr[i,j]]++;
        }
    }
    return frequencyArr;
}
// Метод вывода массива в консоль
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i<arr.Length-1; i++)
        Console.Write(arr[i]+", ");
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int[,] testArr = Gen2DArray(m, n, 0, 50);
Print2DArray(testArr);
Print1DArray(CreateFrequencyArr(testArr, 50));