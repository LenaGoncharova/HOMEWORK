// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
Сonsole.Clear();
 
 double[] CreateArrayRndDouble (int size, int min, int max)
{
double[] array = new double[size];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
double num = rnd.NextDouble() * (max - min) + min;
array[i] = Math.Round(num, 1);
}
return array;
}

