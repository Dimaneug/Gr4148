// Напишите программу замены элементов массива:
// положительные элементы замените на 
// соответствующие отрицательные, и наоборот.

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

// Инвертирование элементов массива 
void InverseArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = arr[i] * (-1);
}

int[] testArr = Gen1DArray(10, -100, 100);
Print1DArray(testArr);
InverseArr(testArr);
Print1DArray(testArr);

