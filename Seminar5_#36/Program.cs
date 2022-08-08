// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
int ArraySearch(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

//***********************
Console.Write("Программа задает одномерный массив, заполненный случайными числами и находит сумму элементов, стоящих на нечётных позициях");
Console.WriteLine("");

Console.Write("Введите желаемую размерность массива ");
int arrLen = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите диапазон чисел для заполнения массива через пробел ");
string[]? dipArr= Console.ReadLine().Split(' ');
int arrL = int.Parse(dipArr[0]);
int arrR = int.Parse(dipArr[1]);

int[] array = FillArrayWithRandomNumbers(arrLen, arrL, arrR);

//int[] array = FillArrayWithRandomNumbers(7, -100, 100);
int summma = ArraySearch(array);

Console.WriteLine("В массисве " + '[' + string.Join(", ", array) + ']' + " сумма элементов, стоящих на нечётных позициях = " + summma);
