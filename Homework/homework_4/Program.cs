//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//Console.WriteLine("Input numbers");
//int A = Convert.ToInt32(Console.ReadLine());
//int B = Convert.ToInt32(Console.ReadLine());
//{
//    for(int i = 0; i <= B; i++)
//  {
//     int Degree = A ^ B;
//
//  }
//}
//Console.WriteLine($" Degree of " + Math.Pow(A, B));

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(number);
// int summa = 0;
// while (number > 0)
// {
//     summa = summa + number % 10; 
//     number = number / 10;        
// }
// Console.WriteLine($"The sum of all digits is {summa}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray (int size)
{
   
   int[] newArray = new int[size];
   for(int i = 0; i < size; i++)
   {
      newArray[i] = new Random().Next(1, 100);
   }
   return newArray;
}

void ShowArray (int[] array)
{
   for(int i = 0; i < array.Length; i++)
   {
       Console.Write (array[i] + " ");
    }
   Console.WriteLine ();
}
Console.WriteLine ("Input array size:");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateRandomArray(size ));