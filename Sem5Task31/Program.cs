// Задайте массив из 12 элементов, заполненный случайными числами из промежутка
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int globPosSum = 0;
int globNegSum = 0;

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
    for (int i =0;i<len;i++)
        res[i] = new Random().Next(bot, top+1);
    return res;
}

// Метод вывода массива в консоль
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i<arr.Length-1; i++)
        Console.Write(arr[i]+", ");
    Console.WriteLine(arr[arr.Length-1]+"]");
}

void NegPosSumV1(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]>0)
            globPosSum += arr[i];
        else
            globNegSum += arr[i];
    }
}

int[] NegPosSumV2(int[] arr)
{
    int positiveSum = 0;
    int negativeSum = 0;
    int[] outArr = new int[2];
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]>0)
            positiveSum += arr[i];
        else
            negativeSum += arr[i];
    }
    outArr[0] = positiveSum;
    outArr[1] = negativeSum;
    return outArr;
}

(int positiv, int negative) NegPosSumV3(int[] arr)
{
    int positiveSum = 0;
    int negativeSum = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]>0)
            positiveSum += arr[i];
        else
            negativeSum += arr[i];
    }
    return(positiveSum, negativeSum);
}


int[] testArr = Gen1DArray(12,-9,9);
Print1DArray(testArr);
NegPosSumV1(testArr);
(int positiv, int negativ) sum = NegPosSumV3(testArr);
int[] res = NegPosSumV2(testArr);

Console.WriteLine("Сумма положительных чисел в массиве(v1): " + globPosSum);
Console.WriteLine("Сумма отрицательных чисел в массиве(v1): " + globNegSum);

Console.WriteLine("Сумма положительных чисел в массиве(v2): " + res[0]);
Console.WriteLine("Сумма отрицательных чисел в массиве(v2): " + res[1]);

Console.WriteLine("Сумма положительных чисел в массиве(v3): " + sum.positiv);
Console.WriteLine("Сумма отрицательных чисел в массиве(v3): " + sum.negativ);