// Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5  78 -> третьей цифры нет 32679 -> 6

Console.Clear();
Console.Write("введите любое целое число- ");
int num = Math.Abs (Convert.ToInt32(Console.ReadLine()));

void TherdNum(int number)
{
    int cons = number;
    while (number > 1000)
    {
        number = number / 10;
    }
     Console.WriteLine($" {cons}->{number % 10}");
}
if (num > 99)
    TherdNum(num);
else Console.WriteLine("третьей цифры нет");
