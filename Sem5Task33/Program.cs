// Задайте массив. Напишите программу, которая определяет,
// присутсвтует ли заданное число в массиве.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерация одномерного массива
int[] Gen1DArray(int len, int bot, int top)
{
    if (bot > top)
    {
        int buf = bot;
        bot = top;
        top = buf;
    }

    int[] res = new int[len];
    for (int i = 0; i < len; i++)
        res[i] = new Random().Next(bot, top + 1);
    return res;
}

// Метод вывода массива в консоль
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write(arr[i] + ", ");
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Проверка на наличие элемента в массиве
void SearchElmInArr(int[] arr, int num)
{
    bool isFound = false;
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i] == num)
        {
            isFound = true;
            Console.WriteLine("Элемент найден в ячейке " + i);
            break;
        }   
    }
    if (!isFound)
        Console.WriteLine("Элемент не найден!");
}

int[] testArr = Gen1DArray(5, -100, 100);
Print1DArray(testArr);
int num = ReadData("Введите число: ");
SearchElmInArr(testArr, num);
