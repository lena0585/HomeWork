//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
//Console.WriteLine("Input number a:");
//int numbera = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Input number b:");
//int numberb = Convert.ToInt32(Console.ReadLine());
//int max = numbera;
//if (numbera > numberb)
//{
  //Console.WriteLine(max = numbera);
//}
//if (numbera < numberb)
//{
  //Console.WriteLine(max = numberb);
//}
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
//Console.WriteLine("Input number a:");
//int numbera = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Input number b:");
//int numberb = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Input number c:");
//int numberc = Convert.ToInt32(Console.ReadLine());
//int max = 0;
//if (numbera > numberb)
//{
//if (numbera > numberc)
//{
  //Console.WriteLine(max = numbera);
//}
//else
//{
  //Console.WriteLine(max = numberc);
//}
//}
//else if (numberb > numberc)
//{
 //Console.WriteLine(max = numberb); 
//}
//else
//{
  //Console.WriteLine(max = numberc);
//}
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет
//Console.WriteLine("Input number ");
//int number = Convert.ToInt32(Console.ReadLine());

//if(number % 2 == 0)
//{
  //Console.WriteLine("numberEven");
//}
//else
//  if(number % 2 != 0)
//{
  //Console.WriteLine("numberOdd");
//}
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Input  N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("numberEven from 1 ,to n");
int num1 = 1;
while(num1 <= n)
{
  if(num1 % 2 == 0)
  Console.Write(num1 + ",");
  num1 ++;
}