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
        return 0;
  else
    {
        int res = Convert.ToInt32(Math.Pow(num1, num2));
        return res;
  
    }
}  
int powerNumber = PowerNumber(number1, number2); 
if  (number2<0) Console.WriteLine( "Ввели не натуральную степень");
else
 Console.WriteLine($"{number1} в степени {number2} = {powerNumber}");   
  



 






 
    