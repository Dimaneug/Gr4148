// Напишите программу, которая принимает на вход координаты
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер 
// четверти плоскости, в которой находится эта точка.

// Метод читает данные от пользователя
int ReadData(string msg) 
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод отправляет четверть по координатам точки
void PrintQuarterTest(int x, int y) 
{
    if (x>0 && y>0) Console.WriteLine("Точка в 1 четверти");
    if (x>0 && y<0) Console.WriteLine("Точка в 2 четверти");
    if (x<0 && y<0) Console.WriteLine("Точка в 3 четверти");
    if (x<0 && y>0) Console.WriteLine("Точка в 4 четверти");

}

int coordX = ReadData("Введите X: ");
int coordY = ReadData("Введите Y: ");
PrintQuarterTest(coordX, coordY);
