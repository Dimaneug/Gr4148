Console.Write("Введите число: ");
string? line = Console.ReadLine();

if (line != null) {
    int num = int.Parse(line);

    if (num % 2 == 0) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}