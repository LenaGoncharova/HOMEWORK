// //  Методы создания массива из консоли
 using System;
 using static System.Console;
 WriteLine("Введите массив через пробел: ");
 // 1 Метод считывающий массив из консоли,введенный строкой
 int[]GetStringArray(string StringArr)
 {
 string[]arr=StringArr. Split(' ',StringSplitOptions.RemoveEmptyEntries);
//  разбивает нашу 
//  строку в строчном массивен на подстроки через пробел (' ').
// // метод= Split(' ',)- создает строку и разбивает ее сепаратором (' ')  для того чтобы 
// //  данные вводились через строку.
// // StringSplitOptions.RemoveEmptyEntries- удаляет пустые элементы при введении массива.

     int[]getarr= new int[arr.Length];
    for (int i = 0; i <arr.Length ; i++)
    {
         getarr[i]= int.Parse(arr[i]);
     }
     return getarr;
 }

 void PrintArray(int[] arr)
 {
     Console.Write("[");
     for (int i = 0; i < arr.Length; i++)
     {
       if (i<arr.Length-1) Console.Write($"{arr[i]}, ");     
       else Console.Write($"{arr[i]}");
     }
     Console.WriteLine("]");
 }
 
    


 int[]getStringArray=GetStringArray(ReadLine());
 PrintArray(getStringArray);

//2  метод сознания массива из консоли, путем введения  ввода в конслоль массива
// WriteLine("Введите размер массива м : ");
// int m= Convert.ToInt32(ReadLine());

// int[]GetMassiveArray( int x)
// {
//    int[]arr= new int[x];
//    for (int i = 0; i < x; i++)
//    {
//     WriteLine($"Введите число с индексом {i}");
//      arr[i]= Convert.ToInt32(ReadLine());
//    }
//    return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//        if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
//        else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }
// int[]getMassiveArray=GetMassiveArray(m);
// PrintArray(getMassiveArray);
