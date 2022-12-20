// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число num: ");
int num = Convert.ToInt32(Console.ReadLine());
int digit3 = num%100;
int digit2 = digit3/10;
Console.WriteLine($"Вторая цифра: {digit2}");