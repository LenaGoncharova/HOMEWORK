//Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// [345, 897, 568, 234] -> 2

 
Console.Clear();
int [] array= new int [6];
void NewArray(int[] arr)
{
    Random rnd= new Random();
    for (int i = 0; i < arr. Length; i++)
    {
      arr[i] = rnd.Next(0,10);
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

 int SumElements(int[] arr)
 {
     int sum=arr[1];
     for (int i = 2; i <arr. Length; i++)
     {
        if(i%2==1 ) sum=sum+arr[i];
     }
     return sum;
 }
 NewArray(array);
 PrintArray (array);

 int sumElements=SumElements(array);
 Console.Write( $"сумма элементов, стоящих на нечётных позициях = {sumElements}");