﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// Console.Write("Введите количество элементов массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] Array = new int[m];

// void mas(int m)
// {
// for (int i = 0; i < m; i++)
// {
// Console.WriteLine($"Введите {i+1} элемент массива ");
// Array[i] = Convert.ToInt32(Console.ReadLine());
// }

// }

// int kol(int[] Array)
// {
// int i=0;
// int sum = 0;
// while (i < Array.Length)
// {
// if(Array[i]>0)
// sum = sum + 1;
// i = i + 1;
// }
// return sum;
// }

// mas(m);
// Console.Write($"\n Чисел больше нуля: {kol(Array)}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using System;
Console.WriteLine("Input coordinate b1 point: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate k1 point: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate b2 point: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate k2 point: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = ((b2 - b1) / (k1 - k2));
double y = ((k1*x) + b1);
Console.WriteLine($"Point of intersection of two lines {x},{y}");
