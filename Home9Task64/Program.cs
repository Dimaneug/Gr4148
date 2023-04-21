// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от 1 до N. Выполнить с помощью рекурсии.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Вывод чисел от 1 до N рекурсивно
string LineGenRec(int numN)
{
    return (numN>0)?LineGenRec(numN-1)+numN+" ":String.Empty;
}

int numN = ReadData("Введите N: ");
Console.WriteLine(LineGenRec(numN));
