//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
int[,] CreateMatrix1(int rows, int coloms, int min, int max)
{
    int[,] matrix1 = new int[rows, coloms];
    Random rnd = new Random();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLongLength(1); j++)
        {
            matrix1[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix1;

}

int[,] CreateMatrix2(int rows, int coloms, int min, int max)
{
    int[,] matrix2 = new int[rows, coloms];
    Random rnd = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLongLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix2;

}

void PrintMatrix(int[,] matrix)
{

  for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j< matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j] },");
           else Console.Write($" {matrix[i, j]}"); 
    
   
        }
        Console.WriteLine("|");
    } 
    
    
     
}

int[,]MultiplicationMatrix( int[,]arr1, int[,]arr2)
{
   int[,]matrix3= new int[ arr1.GetLength(0), arr2.GetLength(1)];
      if (arr1.GetLength(1) == arr2.GetLength(0))
   for (int i = 0; i <matrix3.GetLength(0); i++)
   {
     for (int j = 0; j <matrix3.GetLength( 1 ); j++)
     {
         matrix3[i,j]=0;
         
         {
             for (int k = 0; k <arr1.GetLength(1) ; k++)
             {
                 matrix3 [i,j]+= arr1[ i,k] *arr2[k,j];
             }
         }
     }
   }
   return matrix3;
}
  



 int[,] matrix1 = CreateMatrix1(4, 4, 1, 2);
  PrintMatrix(matrix1);
  Console.WriteLine();
 
int[,] matrix2 = CreateMatrix1(4, 3, 1, 2);
PrintMatrix(matrix2);
Console.WriteLine();
int[,]matrix3=MultiplicationMatrix( matrix1,matrix2 );
PrintMatrix(matrix3);