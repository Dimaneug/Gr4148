// Найдите произведение пар чисел в одномерном массиве.
// Парой считается первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

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

// Генерация массива, элементы которого являются произведениями 
// пар элементов переданного массива
int[] ConvertArr(int[] arr)
{
    int len = arr.Length%2==0?arr.Length/2:arr.Length/2+1;
    int[] outArr = new int[len];
    for (int i = 0; i< len; i++)
    {
        outArr[i] = arr[i]*arr[arr.Length-1-i];
    }
    return outArr;
}

int[] testArr = Gen1DArray(11, 0, 10);
Print1DArray(testArr);
int[] pairsArr = ConvertArr(testArr);
Print1DArray(pairsArr);

