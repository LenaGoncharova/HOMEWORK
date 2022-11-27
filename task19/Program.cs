// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Ввдетие пятизначное число:  ");
int n = Math.Abs( Convert.ToInt32(Console.ReadLine()));

bool Palindrome (int x)
{
  int num1=x%10;
  int num2=((x/10)%10); 
  int num3= ((x/1000)%10); 
  int num4=((x/10000)%10);
  return num1==num4 && num2==num3;
}
 bool res =Palindrome( n);
 Console.Write ($"{n}->");
Console.WriteLine( res ?"Да":"Нет");