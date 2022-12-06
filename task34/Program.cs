// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.Clear();

int[] NewArray(int size )
{
    int[]array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 1001);
    }
    return array;
}

void PrintArray(int[] arr)
{
     Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
       else Console.Write($"{arr[i]}");
     }
     Console.WriteLine("]");
 }

 int EvenNumbers(int[] arr)
 {
    int sum=0;
    for (int i = 0; i <arr. Length; i++)
    {
        if (arr[i]%2==0) sum++;
    }
    return sum;
 }
 int[]newArray=NewArray(6);
  PrintArray(newArray);

  int evenNumbers= EvenNumbers(newArray);
   Console.Write($"количество  четных чисел в массиве = {evenNumbers} ");