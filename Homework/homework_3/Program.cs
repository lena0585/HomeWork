//Задача 19Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

//Console.WriteLine("Input nomber: ");
//string number = Console.ReadLine();
//int numLength = number.Length;

//if (numLength == 5)
//{
 //if (number[0] == number[4] && number[1] == number[3])
   // {
 //Console.WriteLine($"{number} - paliendrom");
   // }
 //else
   // {
 //Console.WriteLine($"{number} - no paliendrom");
   // }
//}

//Задача21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//double FindDistance(double x1, double y1, double c1, double x2, double y2, double c2)
//{
  //  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((c2-c1), 2));
//}

//Console.WriteLine("Input coordinate X of A point: ");
//double x1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Input coordinate Y of A point: ");
//double y1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Input coordinate C of A point: ");
//double c1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Input coordinate X of B point: ");
//double x2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Input coordinate Y of B point: ");
//double y2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Input coordinate C of A point: ");
//double c2 = Convert.ToDouble(Console.ReadLine());
//double distance = FindDistance(x1, y1, c1, x2, y2, c2);
//Console.WriteLine($"Distance between A and B is {distance}");

//Задача 23Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int n = Cube("Input nuber N: ");
for (int i = 1; i <= n; i++)
{
    Console.Write($"{i * i * i}, ");
}
int Cube(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
