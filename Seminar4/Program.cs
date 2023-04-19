// Задача 1. Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
/*
int QuantityOfDigits(int number)
{
    int quantity = 0;
    if(number == 0) quantity = 1;

    while(number != 0)
    {
        number /= 10;
        quantity++;
    } 

    return quantity;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = QuantityOfDigits(number);
Console.WriteLine($"Цифр в вашем числе: {result}");
*/

// Задача 2. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int Sum(int num)
{
    int result = 0;
    // int count = 1;
    // while(count <= num)
    // {
    // result = count + result;
    // count++;
    // }

    for(int count = 1; count <= num; count++) result = count + result;
    
    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число: {num}, Сумма: {Sum(num)}");
*/

// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*
int Factorial(int num)
{
    int count = 1;
    int result = 1;
    while(count <= num)
    {
    result = count * result;
    count++;
    }
    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число: {num}, Факториал: {Factorial(num)}");
*/
