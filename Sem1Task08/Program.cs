Console.Write("Введите число: ");
string? line = Console.ReadLine();

if (line != null) {
    int num = int.Parse(line);

    for (int i = 2; i <= num; i += 2) {
        Console.Write("{0} ", i);
    }

    Console.WriteLine();

}
