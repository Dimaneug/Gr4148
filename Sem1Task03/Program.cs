Console.WriteLine("Введите день недели");
string? dayLine = Console.ReadLine();

if (dayLine != null) {
    string[] dayWeek = new string[7];
    dayWeek[0] = "Понедельник";
    dayWeek[1] = "Вторник";
    dayWeek[2] = "Среда";
    dayWeek[3] = "Четверг";
    dayWeek[4] = "Пятница";
    dayWeek[5] = "Суббота";
    dayWeek[6] = "Воскресенье";

    int day = int.Parse(dayLine);

    if ((0 < day) && (day < 8)) {
        Console.WriteLine(dayWeek[day-1]);
    }
    else Console.WriteLine("Неправильный день недели");

}