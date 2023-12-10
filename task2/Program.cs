//Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] arr = new int[10];
int count = 0;
for (int i=0; i<arr.Length; i++)
{
    arr[i] = new Random().Next(1,20);
    Console.Write($"{arr[i]} ");
    if (arr[i]%2 ==0)
    {
        count++;
    }
}
Console.WriteLine($"\nКоличество четных чисел в массиве = {count} ");