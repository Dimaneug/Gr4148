string? inLine = Console.ReadLine();

if (inLine != null) {
    int inNumber = int.Parse(inLine);

    int outNumber = inNumber*inNumber;
    
    Console.WriteLine(outNumber);
}
