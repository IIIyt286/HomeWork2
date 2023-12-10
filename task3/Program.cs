// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива
double[] arr = new double[10];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().NextDouble() + 0.1;
    Console.Write($"{arr[i].ToString("F5")} ");
}
double min = arr[0];
double max = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    if (arr[i] < min)
    {
        min = arr[i];
    }
}
double diff = max - min;
Console.WriteLine($"\nМинимальный элемент массива: {min.ToString("F5")} \nМаксимальный элемент массива: {max.ToString("F5")} \nРазница между Максимальным и Минимальным элементом массива равна: {diff.ToString("F5")} ");