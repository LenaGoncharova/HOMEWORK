// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.WriteLine("Hello, World!");

int[] array = new int[8];
void FillArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(0, 2);
}
}
void PrintArray(int[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr[i]}, ");
}
Console.Write("]");
}
FillArray(array);
PrintArray(array);