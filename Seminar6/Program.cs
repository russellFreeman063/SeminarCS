// Задача 1. Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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

// void ReverseArray(int[] array)
// {
//     for(int i = 0, j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp; 
//     }
// }

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// ReverseArray(myArray);
// ShowArray(myArray);


// Задача 2. Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

// bool CheckTriangle(int a, int b, int c)
// {
//     if ((a + b) <= c || (b + c) <= a || (c + a) <= b) return false;
//     return true;
// }

// Console.Write("Введите A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите C: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if(CheckTriangle(a, b, c)) Console.WriteLine("Треугольник может существовать.");
// else Console.WriteLine("Треугольник не может существовать.");


// Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// int[] CreateFibonachiArray(int size)
// {
//     int[] array = new int[size];
//     array[0] = 0;
//     array[1] = 1;
//     for(int i = 2; i < array.Length; i++)
//          array[i] = array[i - 2] + array[i - 1];
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// Console.Write("Введите количество: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateFibonachiArray(size);
// ShowArray(array);


// Задача 4. Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int[] CopyArray(int[] array)
// {
//     int[] arrayCopy = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//         arrayCopy[i] = array[i];
//     return arrayCopy;
// }

// int[] myArray = {5, 51, 3, 90, 1};
// int[] arrayCopy = CopyArray(myArray);
// ShowArray(myArray);
// ShowArray(arrayCopy);




