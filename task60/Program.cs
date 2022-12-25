// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
Console.Clear();


int[,,]Array3D( int height,int dows,int colums, int min, int max)
{
  int[,,]array= new  int [ height, dows, colums ];

   array[0,0,0]=10;
   array[1,1,0]=99;
   array[1,0,0]=22;
    array[0,1,0]=36;

   int count=1;
  for (int i = 0; i <array.GetLength(1) ; i++)
  {
    for (int j = 0; j <array.GetLength(0); j++)
   {

        for (int k = 1; k <array.GetLength(2) ; k++)
        {
              
    
            array[i,j,k]=array[0,0,0]+count;
    
            count+=1;
        }
       
    } 

      
  }
 
  return array;
}




void Print3DArray ( int[,,] arr )
{
  for (int i = 0; i < arr.GetLength(0) ; i++)
  {
    for (int j = 0; j <arr.GetLength(1); j++)
    {
        for (int k = 0; k< arr.GetLength(2); k++)
        {
          if( k < arr.GetLength(2) )Console.Write($"{arr[i,j,k] } ({i},{j},{k} )");
        
        }
    
    }
       Console.WriteLine();
  }

 
}

  
   

int[,,]resalt=Array3D( 2,2,2,10,100);

Console.WriteLine();
Print3DArray( resalt);