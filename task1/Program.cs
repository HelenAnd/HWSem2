// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000);
Console.WriteLine("Ваше случайное трехзначное число: " + number);
int digit1 = number/100;
Console.WriteLine($"Первая цифра: {digit1}");
int digit2 = number%10;
Console.WriteLine($"Третья цифра: {digit2}");
Console.WriteLine($"Ваше двузначное число: {digit1}{digit2}");