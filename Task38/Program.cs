// Задайте массив вещественных(тип double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArray(int size)
{
    double[] arr = new double[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((new Random().Next(99) + new Random().NextDouble()), 2);
    }
    return arr;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(num);

Console.WriteLine("[" + string.Join(", ", array) + "]");

double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"максимальное число: {max}");
Console.WriteLine($"минимальное число: {min}");
Console.WriteLine("Разница между max и min = " + (max-min));