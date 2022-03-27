// See https://aka.ms/new-console-template for more information

// Задача 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Random rnd = new Random();
Console.WriteLine("Введите необходимое количество чисел в массиве:");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
for (int i=0; i<size; i++) 
{
    array[i] = rnd.Next() - rnd.NextDouble() * rnd.Next();
    Console.WriteLine($"{i+1} элемент массива = {array[i]}");
}
double NumberMax = 0;
double NumberMin = array[0];
for (int n=0; n<size; n++){
    NumberMax = Math.Max(NumberMax, array[n]);
    NumberMin = Math.Min(NumberMin, array[n]);
}
Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна {NumberMax - NumberMin}");
