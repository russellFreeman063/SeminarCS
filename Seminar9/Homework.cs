// Задача 1: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// void ShowNums(int num)
// {
//     Console.Write(num + " ");
//     if(num > 1) ShowNums(num - 1);
// }

// ShowNums(9);



// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumOfNumbers(int m, int n)
// {
//     if(m < n) return SumOfNumbers(m + 1, n) + m;
//     if(n < m) return SumOfNumbers(n + 1, m) + n;
//     if(n == m) return m;
//     return 0;
// }

// Console.WriteLine(SumOfNumbers(1, 15));



// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Akkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0 && m > 0) return Akkerman(m - 1, 1);
//     else return (Akkerman(m - 1, Akkerman(m, n - 1)));
// }

// Console.Write(Akkerman(3, 2));