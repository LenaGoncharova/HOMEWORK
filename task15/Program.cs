// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Clear();
// Console.Write("Введите  день  недели : ");
// int day = Convert.ToInt32(Console.ReadLine());

// string Week(int d)
// {
//     if (d == 6 || d == 7) return " это выходной!";
//     if (d >= 1 && d <= 5) return "это будний день";
//     return "Вы ошиблись";
// }

// string week = Week(day);
// Console.WriteLine(week);

Console.Clear();
Console.Write("Введите  день  недели : ");
int day = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.Write("Введите  день  недели : ");
int d = Convert.ToInt32(Console.ReadLine());

 bool Week (int num)
 {
    return num ==6 || num==7 ;


 }
 bool resalt = Week(d); 
 Console.WriteLine( resalt ?"Да":"Нет");