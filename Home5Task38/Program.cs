// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// * Отсортируйте массив методом вставки, 
// а затем найдите разницу между первым и последним элементом.

// Генерация одномерного массива
double[] Gen1DArray(int len, int bot, int top)
{
    if (bot > top)
    {
        int buf = bot;
        bot = top;
        top = buf;
    }

    double[] res = new double[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().NextDouble();
        res[i] += 1 * new Random().Next(bot, top);
    }
    return res;
}

// Метод вывода массива в консоль
void Print1DArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write(arr[i] + ", ");
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Находим разницу между максимальным и минимальным элементом
double DiffMinMax(double[] arr)
{
    double min = Double.MaxValue;
    double max = Double.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    return max - min;
}

// Сортировка вставками
void InsertionSort(double[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        double key = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
        }

        arr[j + 1] = key;
    }
}

double[] testArr = Gen1DArray(10, 0, 10);
Print1DArray(testArr);
Console.WriteLine("Разница: " + DiffMinMax(testArr));
InsertionSort(testArr);
Console.WriteLine("Разница: " + (testArr[testArr.Length-1] - testArr[0]));