// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.t
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

using static System.Console;

Write("Введите целое число:- ");
int n = Convert.ToInt32(ReadLine());

void CubNun(int a)
{
    int count = 1;
    while (count <= a)
    {
        int resalt = Convert.ToInt32(Math.Pow(count,3));
        WriteLine($"{count,2} {resalt,4}");
        count++;
    }

}
if(n>0) 
CubNun( n);
else WriteLine("Число не является натуральным");
