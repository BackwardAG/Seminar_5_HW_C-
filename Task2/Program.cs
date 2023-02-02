// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
int[] arr = new int[size];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rand.Next(leftRange, rightRange + 1);
}
return arr;
}

int[] arr = FillArrayWithRandomNumbers(4, 1, 30);
Console.WriteLine("[" + string.Join(",", arr) + "]");

int sumOdd = 0;

for(int i = 0; i < arr.Length; i++ )
{
    if(i % 2 != 0)
    {
        sumOdd = sumOdd + arr[i];
    }
}
System.Console.WriteLine(sumOdd);


