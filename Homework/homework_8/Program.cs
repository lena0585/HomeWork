﻿// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// void SortDescending(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//    {
//      for (int j = 0; j < array.GetLength(1); j++)
//       {
//         for (int k = 0; k < array.GetLength(1) - 1; k++)
//         {
//            if (array[i, k] < array[i, k + 1])
//           {
//            int temp = array[i, k + 1];
//            array[i, k + 1] = array[i, k];
//            array[i, k] = temp;
//           }
//         }
//       }
//    }
// }
// int[,] Create2DRandomArray (int m, int n)
// {
//     int[,] array = new int[m, n];
//     for(int i = 0; i < m;i++)
//     {
//         for(int j = 0; j < n;j++)
//         {
//             array[i,j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// void Show2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] myArray= Create2DRandomArray (m,n);
// Show2DArray(myArray);
// SortDescending(myArray);
// Show2DArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// int[,] Create2DRandomArray (int m, int n)
// {
//     int[,] array = new int[m, n];
//     for(int i = 0; i < m;i++)
//     {
//         for(int j = 0; j < n;j++)
//         {
//             array[i,j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// void Show2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void MinSum(int[,] array)
// {
//     int index = 0;
//     int minsum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i,j];
//         }
//         if (i==0)
//         {
//             minsum=sum;
//         }
//         else if (sum<minsum)
//         {
//             minsum=sum;
//             index = i;
//         }
//     }
//  Console.WriteLine($"{index} - строкa с наименьшей суммой ({minsum})");
// }
// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] myArray= Create2DRandomArray (m,n);
// Show2DArray( myArray);
// MinSum(myArray);

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//  int[,] Create2DRandomArray (int m, int n)
// {
//     int[,] array = new int[m, n];
//     for(int i = 0; i < m;i++)
//     {
//         for(int j = 0; j < n;j++)
//         {
//             array[i,j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// void Show2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int[,] ProductOfTwoArrays(int[,] firstarray, int[,]secondarray)
// {
//     {
//        int [,] multiplearray = new int[firstarray.GetLength(0), secondarray.GetLength(1)]; 
//        int sum =0;
//        for (int i = 0; i < firstarray.GetLength(0); i++)
//         {
//           for (int j = 0; j < secondarray.GetLength(1); j++)
//           {
//               sum = 0;
//             for (int k = 0; k < secondarray.GetLength(1); k++)
//             {
//                 sum += firstarray[i,k] * secondarray[k,j];
//             }
//             multiplearray[i,j] = sum;
//           }
        
//         }
//         return multiplearray;
//     }  
// } 
// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] firstarray = Create2DRandomArray (m,n);
// Show2DArray(firstarray); 
// Console.Write("Введите количество строк ");
// int m1= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// int [,] secondarray= Create2DRandomArray (m,n);
// Show2DArray( secondarray);      
// int [,] multiplearray= ProductOfTwoArrays(firstarray,secondarray);
// Show2DArray( ProductOfTwoArrays(firstarray,secondarray));

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
К сожелению задачи 60 и 62 я не понимаю как делать.