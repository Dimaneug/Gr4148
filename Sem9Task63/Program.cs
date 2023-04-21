// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Вывод чисел от N до 1 рекурсивно
void LineGenRec(int numN)
{
    Console.Write(numN + " ");
    if (numN > 0)
    {
        LineGenRec(numN-1); 
    }
}

int numN = ReadData("Введите N: ");
LineGenRec(numN);
Console.WriteLine();
