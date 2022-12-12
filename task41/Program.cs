// //  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов: ");
int m= Convert.ToInt32(Console.ReadLine());

 int[]FillArray(int m)
 {
    int[]newarr= new int[m];

     for (int i = 0; i < m; i++)     {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        newarr[i] = Convert.ToInt32(Console.ReadLine());
     }
     return newarr;
}


 void PrintArray(int[] arr)  {
   Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
     if(i<arr.Length-1) Console.Write($"{arr[i]}, ");
     else Console.Write($"{arr[i]} ");
  }
    Console.WriteLine("]");
  }

 int SumOfnumbers(int[]arr)
 {
    int res=0;
    for (int i = 0; i <arr. Length; i++)
    {
        if(arr[i]>0)
        res=res+1;
    }
    return res;
 }


 int[]fillArray = FillArray(m);
 PrintArray( fillArray); 
 int sumOfnumbers =SumOfnumbers ( fillArray);
Console.WriteLine($"количество элементов больше 0-->{ sumOfnumbers}");
