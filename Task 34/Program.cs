// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве
Random rnd = new Random();
Console.WriteLine("Введите необходимое количество чисел в массиве:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i=0; i<size; i++) 
{
    array[i] = rnd.Next(100, 1000);
    Console.WriteLine($"{i+1} элемент массива = {array[i]}");
}
int x = 0;
for (int j=0; j<size; j++){
    if (array[j]%2 == 0) x++;
}
Console.WriteLine($"Чётных чисел в массиве всего - {x}");