// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой
// четверти (x и y).

// Метод читает данные от пользователя
int ReadData(string msg) 
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод выводит диапазон координат в заданной четверти
void PrintAnswer(int quarter)
{
    if (quarter == 1) Console.WriteLine("X>0, Y>0");
    if (quarter == 2) Console.WriteLine("X>0, Y<0");
    if (quarter == 3) Console.WriteLine("X<0, Y<0");
    if (quarter == 4) Console.WriteLine("X<0, Y>0");
}

int quarter = ReadData("Введите номер четверти: ");
if (quarter > 0 && quarter < 5)
    PrintAnswer(quarter);
else
    Console.WriteLine("Неправильный номер четверти");