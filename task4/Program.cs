// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
Console.WriteLine("Введите число от 1 до 100 000: ");
int num = Convert.ToInt32(Console.ReadLine());
int size = 0;
    num;
if (num > 0 && num < 100001)
{
    while (temp > 0)
    {
        size++;
        temp = temp / 10;
    }

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[size - 1 - i] = num % 10;
        num = num / 10;
    }

    Console.WriteLine($"Массив из цифр числа:");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
else
{
    Console.WriteLine($"Число {num} не подходит");
}