// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76





double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(leftRange, rightRange) + rand.NextDouble(), 3);
    }
    return arr;
}

void SubtractMaxMin(double[] arr, out double max, out double min, out double result)
{
    max = 0;
    min = 100;
    
    for (int i = 0; i < arr.Length; i++)
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
    Math.Round(result = max - min,3);

}
double[] arr = FillArrayWithRandomNumbers(4, 1, 30);
Console.WriteLine("[" + string.Join(",", arr) + "]");

SubtractMaxMin(arr, out double max, out double min, out double result);
Console.WriteLine($"максимальное число = {max}, а минимальное = {min}, следовательно разница между ними составит {result}");