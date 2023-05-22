// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.


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

// void SortLow2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int m = 0; m < array.GetLength(1) - 1; m++)
//             {
//                 if (array[i, m] < array[i, m + 1])
//                 {
//                     int temp = array[i, m + 1];
//                     array[i, m + 1] = array[i, m];
//                     array[i, m] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] array = CreateRandom2dArray();
// Show2dArray(array);
// SortLow2dArray(array);
// Show2dArray(array);



// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


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

// void LowerSumOfRows2dArray(int[,] array)
// {
//     int minSum = 0;
//     int minRow = 0;
//     int tempSum = 0;

//         for(int i = 0; i < array.GetLength(0); i++)
//         {
//             for(int j = 0; j < array.GetLength(1); j++)
//             {
//                 tempSum += array[i,j];
//             }
//             if(i == 0)
//                 minSum = tempSum;
//             if(tempSum < minSum)
//             {
//                 minSum = tempSum;
//                 minRow = i;
//             }
//             tempSum = 0;
//         }

//     Console.WriteLine($"{minRow + 1} строка");
// }

// int[,] array = CreateRandom2dArray();
// Show2dArray(array);
// LowerSumOfRows2dArray(array);



// Задача 3: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.


// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
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

// int[,] MultiplOf2Matrix(int[,] array1, int[,] array2, int rows1, int rows2, int columns1, int columns2)
// {
//     int rowX = rows1;
//     int colX = columns1;
//     if(rows2 > rows1)
//         rowX = rows2;
//     if(columns2 > columns1) 
//         colX = columns2;

//     int[,] multiplArray = new int[rowX, colX];

//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             multiplArray[i, j] = 0;
//             for (int m = 0; m < array1.GetLength(1); m++)
//             {
//                 multiplArray[i, j] += array1[i, m] * array2[m, j];
//             }
//         }
//     }
//     return multiplArray;
// }

// Console.WriteLine("Введите данные первой матрицы:");
// Console.Write("Введите количество строк: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число: ");
// int minValue1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число: ");
// int maxValue1 = Convert.ToInt32(Console.ReadLine());
// int[,] array1 = CreateRandom2dArray(rows1, columns1, minValue1, maxValue1);

// Console.WriteLine();

// Console.WriteLine("Введите данные второй матрицы:");
// Console.Write("Введите количество строк: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число: ");
// int minValue2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число: ");
// int maxValue2 = Convert.ToInt32(Console.ReadLine());
// int[,] array2 = CreateRandom2dArray(rows2, columns2, minValue2, maxValue2);

// if (array1.GetLength(1) != array2.GetLength(0)) Console.WriteLine("Данные матрицы не умножаются.");
// else
// {
//     Show2dArray(array1);
//     Show2dArray(array2);
//     int[,] multiplArray = MultiplOf2Matrix(array1, array2, rows1, rows2, columns1, columns2);
//     Show2dArray(multiplArray);
// }



// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2


// int[,,] CreateRandom2Digits3dArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество уровней: ");
//     int level = Convert.ToInt32(Console.ReadLine());

//     int[,,] array = new int[rows, columns, level];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             for(int m = 0; m < level; m++)
//                 array[i, j, m] = new Random().Next(10, 99 + 1);


//     return array;
// }

// void Show3dArray(int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             for(int m = 0; m <array.GetLength(2); m++)
//                 Console.Write($"{array[i,j,m]} ({i},{j},{m}) ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,,] array3d = {{{10, 20}, {30, 40}},
//                    {{50, 60}, {70, 80}}};
// Show3dArray(array3d);


// Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.

// string[,] CreateSpiral2dArray()
// {   
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     string[,] array = new string[rows, columns];
//     int count = 1;
//     int tempRow = rows;
//     int tempCol = columns;
//     int y = 0;
//     int index = 1;
//     int i2 = 0;
//     int j2 = 0;

//     while (count < rows * columns)
//     {
//         if (index == count)
//         {
//             for (int j = j2; j < tempCol; j++) 
//             {
//                 if (i2 == y)
//                 {
//                     array[i2, j] = Convert.ToString($"{count:D2}");
//                     count++;
//                 }
//                 if (j == tempCol - 1)
//                 {
//                     for (int i = i2 + 1; i < tempRow; i++) 
//                     {
//                         if (i < tempRow)
//                         {
//                             array[i, tempCol - 1] = Convert.ToString($"{count:D2}");
//                             count++;
//                         }
//                         if (i == tempRow - 1)
//                         {
//                             for (int n = j - 1; n >= y; --n) 
//                             {
//                                 if (j > y)
//                                 {
//                                     array[i, n] = Convert.ToString($"{count:D2}");
//                                     count++;
//                                 }
//                                 if (n == y)
//                                 {
//                                     for (int m = i - 1; m >= y; --m) 
//                                     {
//                                         if (m > y)
//                                         {
//                                             array[m, n] = Convert.ToString($"{count:D2}");
//                                             count++;
//                                         }
//                                         else
//                                         {
//                                             y++;
//                                             tempCol--;
//                                             tempRow--;
//                                             i2++;
//                                             j2++;
//                                             index = count;
//                                             if (array[m + 1, n + 1] == null)
//                                                 array[m + 1, n + 1] = Convert.ToString($"{count:D2}");
//                                         }
//                                     }
//                                 }
//                             }
//                         }
//                     }
//                 }
//             }
//         }
//         else count++;
//     }
//     return array;
// }
                                            
// void Show2dArray(string[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// string[,] array = CreateSpiral2dArray();
// Show2dArray(array);


