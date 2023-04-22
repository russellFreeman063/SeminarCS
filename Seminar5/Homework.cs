// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

// int QuantityEvenArray(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//         if(array[i] % 2 == 0) count++;
//     return count;
// }

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, min, max);
// ShowArray(array);
// Console.WriteLine($"Четных числе в массиве: {QuantityEvenArray(array)}");


// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

// int SumOddPositionArray(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i += 2)
//         sum += array[i]; 
//     return sum;
// }

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, min, max);
// ShowArray(array);
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {SumOddPositionArray(array)}");


// Задача 3: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] CreateDoubleArray(int size)
// {
//     double[] array = new double [size];
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write("Введите значение массива: ");
//         array[i] = Convert.ToDouble(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// double MinElementArray(double[] array)
// {
//     double minElement = array[0];
//     for(int i = 1; i < array.Length; i++)
//         if(array[i] < minElement)
//             minElement = array[i];
//     return minElement;
// }

// double MaxElementArray(double[] array)
// {
//     double maxElement = array[0];
//     for(int i = 1; i < array.Length; i++)
//         if(array[i] > maxElement)
//             maxElement = array[i];
//     return maxElement;
// }

// double MinMaxDifference(double min, double max)
// {
//     double diff = max - min;
//     return diff;
// }

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());

// double[] array = CreateDoubleArray(size);
// double min = MinElementArray(array);
// double max = MaxElementArray(array);
// double diff = MinMaxDifference(min, max);
// ShowArray(array);
// Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) значениям: {diff}");








