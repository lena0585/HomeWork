//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Input number a:");
int numbera = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number b:");
int numberb = Convert.ToInt32(Console.ReadLine());
int max = numbera;
if (numbera > numberb)
{
  Console.WriteLine(max = numbera);
}
if (numbera < numberb)
{
  Console.WriteLine(max = numberb);
}


