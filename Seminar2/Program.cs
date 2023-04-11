// Напишите программу, которая выводит случайное число из отрезка [10, 99]
//  и показывает наибольшую цифру числа.

/*
int BigNum(int num)
{
    int firstNum = num / 10;
    int secondNum = num % 10;
    if (firstNum > secondNum) return firstNum;
    else return secondNum;
}

int randNum = new Random().Next(10,100);
int max = BigNum(randNum);
Console.WriteLine($"Максимальное число из {randNum} это {max}");
*/

// Напишите программу, которая будет принимать на вход два числа и выводить,
//  является ли второе число кратным первому.

/*
bool Numbers(int num1, int num2)
{
    if (num2 % num1 == 0) return true;
    else return false;
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (Numbers(num1, num2)) Console.WriteLine($"Число {num2} является кратным числу {num1}");
else Console.WriteLine($"Число {num2} не является кратным числу {num1}");
*/

// Напишите программу, которая принимает на вход число n и проверяет,
//  кратно ли оно одновременно a и b.

/*
bool Multipl(int n, int a, int b)
{
    if (n % a == 0 && n % b == 0) return true;
    else return false;
}
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (Multipl(n, a, b)) Console.WriteLine($"Число {n} кратно {a} и {b}");
else Console.WriteLine($"Число {n} не кратно {a} и {b}");
*/

// Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого.

/*
bool Quad(int num1, int num2)
{
    if ((num1 * num1 == num2) || (num2 * num2 == num1)) return true;
    else return false;
}

Console.Write("ВВедите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (Quad(num1, num2)) Console.WriteLine($"Числа {num1} и {num2} является квадратом");
    else Console.WriteLine($"Числа {num1} и {num2} не является квадратом");
*/