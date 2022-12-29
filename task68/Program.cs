// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
  Console.Write("Введите число m: ");
  int m =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
  int n =Convert.ToInt32(Console.ReadLine());

int AckermanFunction(int num1, int num2)
{
  if (num1 == 0)
    return num2 + 1;
  else
    if ((num1 != 0) && (num2 == 0))
      return AckermanFunction(num1 - 1, 1);
    else
      return AckermanFunction (num1 - 1, AckermanFunction(num1, num2 - 1));
}


int resalt=AckermanFunction( m,n);
Console.Write(resalt);