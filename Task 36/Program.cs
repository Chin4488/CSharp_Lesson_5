// See https://aka.ms/new-console-template for more information

// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Random rnd = new Random();
Console.WriteLine("Введите необходимое количество чисел в массиве:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i=0; i<size; i++) {
    array[i] = rnd.Next(0, 10000);
    Console.WriteLine($"{i+1} элемент массива = {array[i]}");
}
int j=0;
int summ = array[j];
if (size > 2)
    while (j<size-1) {
    j = j + 2;
    summ = summ + array[j];
        }
Console.WriteLine($"Сумма элементов на нечётных позициях равна {summ}");