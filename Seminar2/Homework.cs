// Задача 1: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int Number2(int num)
{
    int secondNum = num / 10 % 10;
    return secondNum;
}

Console.Write("Введите трёхзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int secondNumber = Number2(num);
System.Console.WriteLine($"Второе число: {secondNumber}");
*/

// Задача 2: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

/*
int Number3(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num = num % 10;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100) Console.WriteLine("Третьей цифры нет");
else{
    int thirdNumber = Number3(num);
    Console.WriteLine($"Третье число: {thirdNumber}");
}
*/

// Задача 3: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool Weekend(int dayNum)
{
    if (dayNum > 5)
        return true;
    else
        return false;
}

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day <= 7)
{
    if (Weekend(day)) Console.WriteLine("Выходной!");
    else Console.WriteLine("Работать.");
}
else Console.WriteLine("Нет такого дня в неделе.");
*/