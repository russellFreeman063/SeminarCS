// Задача 1. Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int GetSumOfNegatives(int[] array)
// {
//     int sum = 0;

//     for(int i = 0; i < array.Length; i++)
//         if(array[i] < 0)
//              sum += array[i];

//     return sum;    
// }

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);

// Console.Write("Сумма отрицательных чисел: " + GetSumOfNegatives(myArray));


// Задача 2. Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

// int[] MakePositive(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] *= (-1);
    
//     return array;
// }

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// MakePositive(myArray);
// ShowArray(myArray);


// Задача 3. Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.

// bool FindNumber(int[] array, int userNumber)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == userNumber)
//             return true;
//     }
//     return false;
// }

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int userNumber = Convert.ToInt32(Console.ReadLine());


// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// if(FindNumber(myArray, userNumber))
//     Console.WriteLine("Число присутствует");
// else Console.WriteLine("Число отсутствует");


// Задача 4. Задайте одномерный массив из m случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

// int QuantityOfElements(int[] array, int a, int b)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
    
//         if(array[i] <= b && array[i] >= a)
//         count++;
    
//     return count;
// }

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите нижний диапазон: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите верхний диапазон: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// int count = QuantityOfElements(myArray, a, b);

// if(count == 0)
//     Console.WriteLine($"В отрезке {a} и {b} нет элементов.");
// else Console.WriteLine($"В отрезке {a} и {b} элементов: {count}");
