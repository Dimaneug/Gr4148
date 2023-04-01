// Напишите программу, которая выводит случайное трёхзначное
// число и удаляет вторую цифру этого числа.

int num = new Random().Next(100,1000);
Console.WriteLine(num);

// int firstNum = num / 100;
// int lastNum = num % 10;
// int newNum = firstNum * 10 + lastNum;

Console.WriteLine((num/100)*10+(num%10));
