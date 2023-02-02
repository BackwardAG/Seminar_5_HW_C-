// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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


int[] arr = FillArrayWithRandomNumbers(4, 100, 999);
Console.WriteLine("[" + string.Join(",", arr) + "]");
int sumEven = 0;


for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] % 2 == 0)
    {
        sumEven = sumEven + 1;
    }

}
System.Console.WriteLine($"Количество четных чисел = {sumEven}");