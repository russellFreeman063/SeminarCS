// Задача 1. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int CountNumbersBiggerThenZero(int size)
// {
//     int count = 0;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите число {i + 1}: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         if(num > 0) count++;
//     }
//     return count;
// }

// Console.Write("Введите количество чисел: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Количество чисел больше нуля: {CountNumbersBiggerThenZero(size)} ");


// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void LinesIntersection(double b1, double k1, double b2, double k2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k1 * x + b1;  
//     Console.WriteLine($"{x}, {y}");
// }

// Console.Write("Введите точку b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите точку k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите точку b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите точку k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// if (k1 == k2 && b1 == b2)
//     Console.WriteLine("Прямые совпадают.");
// else if (k1 == k2)
//     Console.WriteLine("Прямые параллельны.");
// else LinesIntersection(b1, k1, b2, k2);