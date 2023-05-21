// Задача 1. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное число: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное число: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ReverseArray(int[,] array)
// {
//     for (int i = 1; i < array.GetLength(0); i++)
//         for (int j = 0; j < i; j++)
//         {
//             int temp = array[i, j];
//             array[i, j] = array[j, i];
//             array[j, i] = temp;
//         }
// }

// int[,] array = CreateRandom2dArray();
// Show2dArray(array);
// ReverseArray(array);
// Show2dArray(array);

// Залача 2. Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное число: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное число: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ChangeRows2dArray(int[,] array, int rowX, int rowY)
// {
//     if (rowX < array.GetLength(0) && rowY < array.GetLength(0))
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[rowX, j];
//             array[rowX, j] = array[rowY, j];
//             array[rowY, j] = temp;
//         }
//         Show2dArray(array);
//     }
//     else Console.WriteLine("Ошибка при выборе строки");
// }

// int[,] array = CreateRandom2dArray();
// Show2dArray(array);
// Console.Write("Введите номер строки: ");
// int rowX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер строки: ");
// int rowY = Convert.ToInt32(Console.ReadLine());
// ChangeRows2dArray(array, rowX, rowY);


// Задача 3. Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное число: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное число: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[] FindLowerElement2dArray(int[,] array)
// {
//     int min = array[0, 0];
//     int minX = 0;
//     int minY = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             if (array[i, j] < min)
//             {
//                 min = array[i, j];
//                 minX = i;
//                 minY = j;
//             }
//     int[] lowerArray = { minX, minY };
//     return lowerArray;
// }

// int[,] DeleteRowAndColumn2dArray(int[,] array, int[] lowerArray)
// {
//     int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//     int m = 0;
//     int n = 0;

//     for(int i = 0; i < array.GetLength(0); i++)
//     {    
//         if(i != lowerArray[0])
//         {
//             for(int j = 0; j < array.GetLength(1);j++)
//             {
//                 if(j != lowerArray[1])
//                 {
//                     newArray[m,n] = array[i, j];
//                     n++;
//                 }
//             }
//             m++;
//             n = 0;
//         }
               
//     } 
       
//     return newArray;
// }

// int[,] array = CreateRandom2dArray();
// Show2dArray(array);
// int[] lowerArray = FindLowerElement2dArray(array);
// int[,] newArray = DeleteRowAndColumn2dArray(array, lowerArray);
// Show2dArray(newArray);


