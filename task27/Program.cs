// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//  452 -> 11

// 82 -> 10,  ,9012 -> 12
Console.Clear();
Console.Write("Введите первое число:   ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
   int sum=0;
   if (num<0)
   num=Math.Abs(num);
    while (num>0)
     {
       int num1=num%10;
       sum = sum + num1;
       num=num/10;
    
     } 
     return sum; 
}

int sumNumber = SumNumber( number);
Console.Write ($" сумма  цифр числа {number} = {sumNumber}");



