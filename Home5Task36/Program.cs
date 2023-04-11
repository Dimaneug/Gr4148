// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// * Найдите все пары в массиве и выведите пользователю.

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

// Находит сумму элементов, стоящих на нечётных позициях массива
int SumElmOddIndex(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)
        sum += arr[i];
    return sum;
}

// Выводит все пары в массиве
void PrintAllPairs(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        for (int j = i+1; j < arr.Length; j++)
        {
            Console.WriteLine(arr[i]+","+arr[j]+" -> "+i+","+j);
        }
    }
}

int[] testArr = Gen1DArray(10, 0, 10);
Print1DArray(testArr);
Console.WriteLine("Сумма элементов: " + SumElmOddIndex(testArr));
Console.WriteLine("Все пары элементов:");
PrintAllPairs(testArr);
