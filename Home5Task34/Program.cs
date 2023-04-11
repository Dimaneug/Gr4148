// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// * Отсортировать массив методом пузырька и подсчёта. 
// Сравнить быстродействие методов. Проверку сортировки производить отдельно.
// Сначала запустить программу с одним методом, а затем с другим. 
// Проверять на длине массива не менне 10000 элементов.

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

// Подсчёт чётных чисел в массиве
int CountEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
            count++;
    return count;
}

// Сортировка пузырьком
void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

// Сортировка подсчётом
void CountSort(int[] arr, int k)
{
    // массив для хранения отсортированного массива
    int[] output = new int[arr.Length];

    // массив для хранения кол-ва повторений чисел
    int[] freq = new int[k + 1];
    for (int i = 0; i < arr.Length; i++)
        freq[arr[i]]++;

    // Вычисляем начальный индекс для каждого целого числа
    int total = 0;
    for (int i = 0; i < k+1; i++)
    {
        int oldCount = freq[i];
        freq[i] = total;
        total += oldCount;
    }

    // Копируем в список выходов, сохраняя порядок входов с одинаковыми ключами
    for (int i = 0; i < arr.Length; i++)
    {
        output[freq[arr[i]]] = arr[i];
        freq[arr[i]] += 1;
    }

    // Копируем список вывода обратно в список ввода
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = output[i];
    }
}

// Проверка массива на отсортированность
bool CheckSort(int[] arr) 
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        if (arr[i] > arr[i+1])
            return false;
    }
    return true;
}

// Измерение скорости сортировки массива методом пузырька
void MeasureBubbleSort(int[] arr)
{
    DateTime d1 = DateTime.Now;
    BubbleSort(arr);
    Console.WriteLine("Метод пузырька: "+ (DateTime.Now - d1));
}

// Измерение скорости сортировки массива методом пузырька
void MeasureCountSort(int[] arr, int k)
{
    DateTime d = DateTime.Now;
    CountSort(arr, k);
    Console.WriteLine("Метод подсчёта: "+ (DateTime.Now - d));
}

// Верхняя граница для генерации массива
const int K = 999999999;  
// Кол-во элементов
const int N = 10000;  

// Создаём два одинаковых массива
int[] testArr = Gen1DArray(N, 0, K);
int[] testArr1 = new int[testArr.Length];
testArr.CopyTo(testArr1, 0);

// Проверяем метод пузырька
MeasureBubbleSort(testArr);
Console.WriteLine(CheckSort(testArr)?"Массив отсортирован":"Массив не отсортирован");
Console.WriteLine("Количество чётных элементов в массиве: " + CountEven(testArr));

// Проверяем метод подсчёта
MeasureCountSort(testArr1, K);
Console.WriteLine(CheckSort(testArr)?"Массив отсортирован":"Массив не отсортирован");
Console.WriteLine("Количество чётных элементов в массиве: " + CountEven(testArr));

// Вывод: метод подсчёта гораздо быстрее пузырька, если в массиве 
// не так много уникальных элементов.