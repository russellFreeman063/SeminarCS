//  Задача 1. Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.

// void ShowNums(int num)
// {
//     if(num > 1) ShowNums(num - 1);
//     Console.Write(num + " ");
// }

// ShowNums(5);

// Задача 2. Напишите программу, которая будет принимать
//  на вход число и возвращать сумму его цифр.

// int SumOfDigits(int num)
// {
//     if(num != 0) return SumOfDigits(num / 10) + num % 10;
//     return 0;
// }

// Console.WriteLine(SumOfDigits(123));



// Задача 3. Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.


// void ShowNums2(int m, int n)
// {
//     if (n > m)
//     {
//         ShowNums2(m, n - 1);
//         Console.Write(n + " ");
//     }
//     if (m > n)
//     {
//         ShowNums2(m, n + 1);
//         Console.Write(n + " ");
//     }
//     if (m == n) Console.Write(m + " ");
// }

// ShowNums2(5,1);



// Задача 4. Напишите программу, которая на вход принимает два 
// числа A и B, и возводит число А в целую степень B.


// int MultiplyNums(int a, int b)
// {
//     if(b != 0) return MultiplyNums(a, b - 1) * a;
//     return 1;
// }

// Console.WriteLine(MultiplyNums(2,5));