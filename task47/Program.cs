// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
 Console.Clear();

 double[,] CreateMatrixRdDouble (int line, int colums, int min, int max)
{
double[,] matrix = new double[line,colums];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j <  matrix.GetLength(1); j++)
  {
    double num = rnd.NextDouble() * (max - min) + min;
    matrix[i,j] = Math.Round(num, 1);
  }

}
  return matrix;
}

void Print2DArray(double[,] array)
{

for (int i = 0; i < array.GetLength(0); i++)

{
     Console.Write("|");
    for (int j = 0; j <array.GetLength (1); j++)
    {
        if(j < array.GetLength(1) - 1) Console.Write($"{array[i,j],5} ");
        
        else Console.Write($"{array[i,j],5} ");
    }
    Console.WriteLine("|");
}

}


double[,] createMatrixRdDouble=  CreateMatrixRdDouble(5,5,0,20 );
Print2DArray(createMatrixRdDouble);