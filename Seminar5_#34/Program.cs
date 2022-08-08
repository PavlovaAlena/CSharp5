// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//************************
int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange);
    }
    return arr;
}

//************************
int EvenNumberArray(int[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            cnt = cnt + 1;
        }
    }
    return cnt;
}

//************************
Console.Write("Программа заполняет массив случайными положительными трёхзначными числами и показывает количество чётных чисел в массиве");
Console.WriteLine("");

Console.Write("Введите желаемую размерность массива ");
int arrLen = Convert.ToInt32(Console.ReadLine());


int[] array = FillArrayWithRandomNumbers(arrLen, 100, 1000);
int count = EvenNumberArray(array);

Console.WriteLine("В массиве " + '[' + string.Join(", ", array) + ']' + " количество чётных чисел = " + count);