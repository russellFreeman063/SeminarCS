// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
int Degree(int num1, int num2)
{
    int result = 1;
    for(int count = 1; count <= num2; count++)
    {
        result *= num1;
    }
    return result;
}

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Degree(num1, num2));
*/

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int NumberSum(int number)
{
    int sum = 0;
    int num = 0;
   
    while(number != 0)
    {
        num = number % 10;
        sum += num;
        number /= 10;
    }

    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number}: {NumberSum(number)}");
*/

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
int[] ArrayRandom(int lenght, int min, int max)
{
    int[] array = new int[lenght];
    Random random = new Random();

    for(int i = 0; i < lenght; i++)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;    
}

void PrintArray(int[] array)
{
    Console.Write("[");

    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");

}

Console.Write("Введите количество элементов: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное значение: ");
int min  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение: ");
int max  = Convert.ToInt32(Console.ReadLine());
PrintArray(ArrayRandom(length, min, max));
*/