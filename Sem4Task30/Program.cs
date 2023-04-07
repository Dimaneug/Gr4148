// Напишите программу, которая выводит массив из len
// элементов, заполненный [bot,top] элементами в
// случайном порядке

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода массива в консоль
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i<arr.Length-1; i++)
        Console.Write(arr[i]+", ");
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int[] Gen1DArray(int len, int bot, int top)
{
    int[] res = new int[len];
    for (int i =0;i<len;i++)
        res[i] = new Random().Next(bot, top+1);
    return res;
}

int len = ReadData("Введите длину массива: ");
int bot = ReadData("Введите нижнюю границу: ");
int top = ReadData("Введите верхнюю границу: ");
Print1DArray(Gen1DArray(len, bot, top));

