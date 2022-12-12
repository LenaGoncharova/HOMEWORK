// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243  ;2, 4 -> 16
Console.Clear();
Console.Write("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите вторе  число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int PowerNumber(int num1, int num2)
{
    if (number2 == 0)
        return 1;
  else
    {
        int res = Convert.ToInt32(Math.Pow(num1, num2));
        return res;
  
    }
}  

int powerNumber = PowerNumber(number1, number2); 
if  (number2<0) Console.WriteLine( "Ввели не натуральную степень");
if  (number1<0) Console.WriteLine($"{number1} в степени {number2} = - {powerNumber}");
else
Console.WriteLine($"{number1} в степени {number2} = {powerNumber}");   


 
int PowerNumber1(int num1, int num2)
{
   if (num2 == 0)
        return 1;
     int res= num1;
     for (int i = 2; i <num2 ; i++)
     {
        res *=num1;
     }
     return res;
} 
Console.WriteLine($"{number1} в степени {number2} = {powerNumber}");  






 
    