string? firstNumberLine = Console.ReadLine();
string? secondNumberLine = Console.ReadLine();

if (firstNumberLine != null && secondNumberLine != null) {
    int inNumber1 = int.Parse(firstNumberLine);
    int inNumber2 = int.Parse(secondNumberLine);

    if (inNumber1 == (int)Math.Pow(inNumber2, 2)) {
        Console.WriteLine("Yes");
    }
    else Console.WriteLine("No");

}
