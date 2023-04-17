// Перевернуть массив

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
    {
        res[i] = new Random().Next(bot, top);
    }
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

// Разворачивает исходный массив
void ReverseV1(int[] arr) 
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        (arr[i], arr[arr.Length-1-i]) = (arr[arr.Length-1-i], arr[i]);
    }
}

// Возвращает развёрнутый массив
int[] ReverseV2(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = arr.Length-1; i >= 0; i--)
    {
        newArr[arr.Length-i-1] = arr[i];
    }
    return newArr;
}

int[] testArr = Gen1DArray(11, 0, 20);
Print1DArray(testArr);
int[] newArr = ReverseV2(testArr);
Print1DArray(newArr);
ReverseV1(testArr);
Print1DArray(testArr);

