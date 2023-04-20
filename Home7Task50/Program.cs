// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерация двумерного массива с числами Фибоначчи
int[,] Gen2DArrayFib(int m, int n)
{
    int a = 0;
    int b = 1;

    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = a;
            (a, b) = (b, a + b);
        }
    }
    return res;
}

// Печать двумерного массива
void PrintFind2DArray(int[,] arr, int m, int n)
{   
    if (arr.GetLength(0) > m && arr.GetLength(1) > n)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (i ==m && j ==n)
                {
                    ConsoleColor defaultColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(arr[i, j] + " ");
                    Console.ForegroundColor = defaultColor;
                }
                else
                    Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    else 
        Console.WriteLine("Такого элемента нет!");
}


int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int[,] testArr = Gen2DArrayFib(m,n);
m = ReadData("Введите номер строки: ");
n = ReadData("Введите номер столбца: ");
PrintFind2DArray(testArr, m,n);

