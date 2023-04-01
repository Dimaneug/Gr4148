// Напишите программу, которая на вход принимает число и 
// выдаёт его квадрат (число умноженное на само себя).

string? inLine = Console.ReadLine();

if (inLine != null) {
    int inNumber = int.Parse(inLine);

    int outNumber = inNumber*inNumber;
    
    Console.WriteLine(outNumber);
}
