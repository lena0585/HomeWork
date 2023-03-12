// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// int[] CreateRandomArray (int size)
// {
//    int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//    {
//        newArray[i] = new Random().Next(100, 999);
//    }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//    for(int i = 0; i < array.Length; i++)
//     {
//        Console.Write (array[i] + " ,");
//    }
//    Console.WriteLine ();
// }

// int EvenNumber( int[]array)
// {
//   int num = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             num ++;
//     }

//     return num;
// }
// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray (size);
// ShowArray (myArray);
//  Console.WriteLine($"Количество чётных чисел в массиве: " + EvenNumber(myArray));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// int[] CreateRandomArray (int size)
// {
//    int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//    {
//        newArray[i] = new Random().Next(-100,100);
//    }
//     return newArray;
// }
// void ShowArray (int[] array)
// {
//    for(int i = 0; i < array.Length; i++)
//     {
//        Console.Write (array[i] + " ,");
//    }
//    Console.WriteLine ();
// }
// int SumOddNumbers( int[]array)
// {
//   int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//             sum += array[i];
//     }

//            return sum;
// }
// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray (size);
// ShowArray (myArray);
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве равна: {SumOddNumbers(myArray)}"); 

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
float[] A = new float[5];
 int i =0;
   for(i = 0; i < 5; i++ )
{
   A[i] = new Random().Next(1, 100);
    Console.Write(A[i] + " ,");
}
Console.WriteLine();
double maxNumber = A [0];
double minNumber = A [0];
  for (int j = 1; j < A.Length; j++)
  {
    if (maxNumber < A[j])
    {
      maxNumber = A[j];
    }
        if (minNumber > A[j])
    {
      minNumber = A [j];
    }
  }
  double decision = maxNumber - minNumber;
Console.WriteLine($"Difference between maximum({maxNumber}) and minimum({minNumber}) elements: {decision}");