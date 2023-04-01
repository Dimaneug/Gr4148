// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
string? line = Console.ReadLine();

if (line != null) {
    int num = int.Parse(line);

    for (int i = 2; i <= num; i += 2) {
        Console.Write("{0} ", i);
    }

    Console.WriteLine();

}
