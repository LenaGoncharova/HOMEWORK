// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

  Console.Clear();
  Console.Write("Введите число M: ");
  int m =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
  int n =Convert.ToInt32(Console.ReadLine());

  int SummNumbers( int num1, int num2)
  {
    if( num1>num2) return 0;
    return num1+SummNumbers( num1+1,num2);
  }

int  resalt=  SummNumbers( m, n);
Console.Write( resalt );