// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Вычисляет расстояние между точками в 3D
double CalcDistance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
}

int x1 = ReadData("Введите x1: ");
int y1 = ReadData("Введите y1: ");
int z1 = ReadData("Введите z1: ");
int x2 = ReadData("Введите x2: ");
int y2 = ReadData("Введите y2: ");
int z2 = ReadData("Введите z2: ");
Console.WriteLine(CalcDistance3D(x1, y1, z1, x2, y2, z2));
