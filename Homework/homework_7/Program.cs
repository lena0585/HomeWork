// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double [,] Generate2DArray(int m, int n)
// {
//     double[,] myArray = new double [m, n];
  
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             myArray[i,j] = Math.Round(new Random().Next(-9,9) + new Random().NextDouble(),1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray (double[,] myArray)
// {
//     for(int i = 0; i < myArray.GetLength(0);i++)
//     {
//         for(int j = 0; j < myArray.GetLength(1);j++)
//         {
//             Console.Write(myArray[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] arr2D = Generate2DArray(m, n);
// Show2DArray(arr2D);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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
// void PositionElement(int[,] array , int a, int b)
// {
//     if (a >= array.GetLength(0) || b >= array.GetLength(1))
//     {
//         System.Console.Write("Такого числа нет ");
//     }
//     else 
//     {
//         System.Console.Write(array[a,b] + " ");
//     }
// }
// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите строку элемента ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите столбец элемента ");
// int b = Convert.ToInt32(Console.ReadLine());
// int[,] myArray= Create2DRandomArray (m,n);
// Show2DArray(myArray);
// PositionElement(myArray, a, b);

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2DRandomArray (int m, int n)
{
    int[,] array = new int[m, n];
    for(int i = 0; i < m;i++)
    {
        for(int j = 0; j < n;j++)
        {
            array[i,j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void Show2DArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
double[] Average(int[,] array)
{
    double[] result = new double[array.GetLength(0)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum=0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum+=array[i,j];
        }
        result[j]=Math.Round(sum/array.GetLength(0),3);
    }
    return result;
}

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray= Create2DRandomArray (m,n);
Show2DArray(myArray);
double[] averagen=Average(myArray);
Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ",averagen)}");