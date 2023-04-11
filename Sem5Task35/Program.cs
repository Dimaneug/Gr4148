// Задайте одномерный массив из 123 случайнх чисел.
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].

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

int CountElmInRange(int[] arr, int min, int max) 
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i]>=min && arr[i]<=max) 
            count++;
    }
    return count;
}

int[] testArr = Gen1DArray(123, 0, 100);
Print1DArray(testArr);
int res = CountElmInRange(testArr, 10, 99);
Console.WriteLine("Количество элементов из области [10,99]: " + res);
