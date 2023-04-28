// Задача 1. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// double[,] CreateRandomDouble2dArray(int rows, int columns, double minValue, double maxValue)
// {
//     double[,] array = new double[rows, columns];
//     Random random = new Random();

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = Math.Round(random.NextDouble() * (maxValue - minValue) + minValue, 1);

//     return array;    
// }

// void Show2dArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число: ");
// double minValue = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите максимальное число: ");
// double maxValue = Convert.ToDouble(Console.ReadLine());

// double[,] myArray = CreateRandomDouble2dArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);



// Задача 2. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);

//     return array;    
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void PrintElementOf2dArray(int[,] array, int userRow, int userColumn)
// {
//     if(userRow < array.GetLength(0) && userColumn < array.GetLength(1))
//         Console.WriteLine($"Элемент на позиции {userRow} {userColumn}: {array[userRow, userColumn]}");
//     else Console.WriteLine($"На позиции {userRow} {userColumn} нет элемента");
// }   
    
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите строку позиции: ");
// int userRow = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите столбец позиции: ");
// int userColumn = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);
// PrintElementOf2dArray(myArray, userRow, userColumn);



// Задача 3. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);

//     return array;    
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ShowDoubleArray(double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(Math.Round(array[i], 1) + " ");

//     Console.WriteLine();
// }

// double[] AverageOfColumns2dArray(int[,] array)
// {
//     double[] averageArray = new double[array.GetLength(1)];

//     for(int i = 0; i < array.GetLength(1); i++)
//     {
//         for(int j = 0; j < array.GetLength(0); j++)
//         {
//             averageArray[i] += array[j,i];
//         }

//         averageArray[i] /= array.GetLength(0);
//     }
    
//     return averageArray;
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);
// double[] averageArray = AverageOfColumns2dArray(myArray);
// ShowDoubleArray(averageArray);



