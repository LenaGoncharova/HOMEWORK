// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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


void SortingNumbers(int[,] arr1)
{

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int jx = 0; jx < arr1.GetLength(1); jx++)
        {
            for (int j = 0; j < arr1.GetLength(1) - 1; j++)
            {
                if (arr1[i, j] < arr1[i, j + 1])
                {
                    int k = arr1[i, j];
                    arr1[i, j] = arr1[i, j + 1];
                    arr1[i, j + 1] = k;


                }

            }
        }
    }

}



  


  
    
int[,] createarr = CreateMatrix(4, 6, -7, 10);
PrintMatrix(createarr);
Console.WriteLine();
SortingNumbers(createarr);
PrintMatrix(createarr);