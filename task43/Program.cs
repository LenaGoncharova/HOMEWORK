// k1*x+b1=k2*x+b2
// k1*x-(k2*x)=b2-b1
// x(k1-k2)=b2-b1
// x=(b2-b1)/(k1-k2)
//   Напишите программу, которая найдёт точку пересечения двух прямых,
//   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//   задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// y = k1 * x + b1, y = k2 * x + b2;
 Console.Clear();
// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());
// // if(k1>k2&&k1>k2)
// {
// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;
// Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

// }
// else 
// Console.WriteLine(" прямые не пересекутся ");


// using System;
// using static System.Console;



 double IntersectionPoint( int b1,int b2,int k1,int k2)
 {
   double x= (-b2 + b1)/(-k1 + k2); 
   return x; 
  
   
 }

 Console.WriteLine("введите значение b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
 int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
int k2 = Convert.ToInt32(Console.ReadLine());


double intersectionPoint=IntersectionPoint( b1,b2, k1, k2);
Console.WriteLine();
Console.WriteLine(intersectionPoint);
// Console.Write("Введите  координаты точки Bx: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите  координаты точки By: ");
// int y2 = int.Parse(Console.ReadLine());

// double Distance(int ax, int ay, int bx, int by)
// {

//     return Math.Sqrt(Math.Pow((bx - ax),2)+ (Math.Pow((by - ay),2)));

// }

// double distance =Math.Round (Distance(x1, y1, x2, y2),2,MidpointRounding.ToZero);
// Console.WriteLine(distance);






// double res = Math.Sqrt(a * b);
// double res1 = Math.Round(res, 2, MidpointRounding.ToZero);
// Console.WriteLine(res1);