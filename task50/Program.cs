// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет
Console.Clear();
 Console.Write("Введите первый индекс  : ");
int inx1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй индекс : ");
int inx2 = Convert.ToInt32(Console.ReadLine());

int[,]MatrixArray( int line,int colums,int min,int max)
{ int[,]matrix=new int[ line,colums];
 Random rnd= new Random(); 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j <  matrix.GetLength(1); j++)
    {
      matrix[i,j]= rnd.Next( min,max+1 );
    }
  }
    return matrix;
}

void PrintMatrix( int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j<arr.GetLength(1)-1)Console.Write($"{arr[i,j],4},");
            else Console.Write($"{arr[i,j],4}");
        }
        Console.WriteLine("|");
    }

}

bool SearchForIndexes(int[,]arr, int inx1,int inx2)
{
    for (int i = 0; i <arr.GetLength (0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
         if( i+1==inx1&& j+1==inx2 || inx1==0 || inx2==0) return true;
  
        }
    
    }
  return false;
}

int[,]matrixArray=MatrixArray( 3,4, 0,40); 
PrintMatrix(matrixArray);
bool searchForIndexes=SearchForIndexes( matrixArray,inx1, inx2);
Console.Write($"индекс {inx1},{inx2} в массиве --> ");
Console.WriteLine(searchForIndexes ? "да" :" нет");