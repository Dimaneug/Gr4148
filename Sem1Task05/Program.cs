string? number = Console.ReadLine();

if (number != null) {
    int endNum = int.Parse(number);
    int startNum = endNum * (-1);
    string res = string.Empty;

    while(startNum <= endNum) {
        res = res + startNum + " ";
        startNum++;
    }

    Console.WriteLine(res);
}
