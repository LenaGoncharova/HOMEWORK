// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 Console. Clear();
Console.Clear();
int[,] CreateMatrix(int line, int colums, int min, int max)
{
    int[,] arr = new int[line, colums];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}
void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],4},");
            else Console.Write($"{arr[i, j],4}");
        }  Console.WriteLine("|");
    }

}
void PrintArray(int[] arr)
 {
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if(i<arr.Length-1) Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]} ");
  }
    Console.WriteLine("]");
 }


int[]SumOfRows( int[,]matrix)
{
    int size= matrix.GetLength(0);
   int[]arr= new int[ size];
    int k=0;

    for (int i = 0; i <  matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
    
           arr[k]+=matrix[i,j];
            
        
        }
    
            k++;
    }

  return arr;

}



int RowsMinSum( int[]arr)
{
    int l=0;
   int min=arr[0];
 for (int i = 0; i <arr. Length; i++)
 {  
   if (arr[i]< min)
   {
     arr[i]=min;
     l=i;
   }
   

 }
  return l;
}











int[,] createarr = CreateMatrix(4, 4, 0, 5);
PrintMatrix(createarr);
int[]sumofrows=SumOfRows(createarr) ;
PrintArray( sumofrows);
Console.WriteLine();
int numrows= RowsMinSum(sumofrows );
Console.WriteLine($"строка с наименьшей суммой элементов => { numrows} ");
