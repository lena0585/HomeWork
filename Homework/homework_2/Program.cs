//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1
// int InCenter(int num)
//{
  //  int result = ((num / 10) % 10);
    //return result;
//}
  //  int randomnum = new Random().Next(100, 1000);

//Console.WriteLine(randomnum);
//Console.WriteLine(InCenter(randomnum));

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
//Console.WriteLine("Input Number:");
//string number = Console.ReadLine();

//if (number.Length<3) 
//{
  //  Console.WriteLine("No Third Number");
    //}
//else
 //{
   // char rezult=number[2];
    //Console.WriteLine(rezult);
    //}

  //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет 
Console.WriteLine("Input numer from 1 to 7");

int N = int.Parse (Console.ReadLine());
if ((N>0) && (N<6))
{
    Console.WriteLine("Weekday!");
}
else if (N == 6 || N == 7) 
{
    Console.WriteLine("Day off!");
} 
 