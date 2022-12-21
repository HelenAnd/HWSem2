// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNum)
{
    if (dayNum == 6 || dayNum == 7)
    {
        Console.WriteLine("(Это выходной день) -> да");
    }
    else if (dayNum < 1 || dayNum > 7)
    {
        Console.WriteLine("Не является днем недели");
    }
    else Console.WriteLine("(Это будний день) -> нет");
}

CheckingTheDayOfTheWeek(dayNum);