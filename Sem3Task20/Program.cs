// Метод читает данные от пользователя
int ReadData(string msg) 
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Вычисляет расстояние между точками в 2D
void CalcDistance2D(int x1, int y1, int x2, int y2)
{
    Console.WriteLine(Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)));
}

int x1 = ReadData("Введите x1: ");
int y1 = ReadData("Введите y1: ");
int x2 = ReadData("Введите x2: ");
int y2 = ReadData("Введите y2: ");
CalcDistance2D(x1, y1, x2, y2);
