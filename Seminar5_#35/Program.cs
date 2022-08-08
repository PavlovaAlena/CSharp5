// Задача 35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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
int ArraySearch(int[] arr, int X, int Y)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= X && arr[i] <= Y)
        {
            cnt = cnt + 1;
        }
    }
    return cnt;
}

//***********************
Console.Write("Программа задает массив из 123 случайных чисел и находит количество элементов массива, значения которых лежат в отрезке [10,99]");
Console.WriteLine("");

int[] array = FillArrayWithRandomNumbers(123, 0, 150);
int count = ArraySearch(array, 10, 99);

Console.WriteLine("В массиве " + '[' + string.Join(", ", array) + ']' + " количество элементов массива, значения которых лежат в отрезке [10,99] = " + count);

/* //******2й вариант с выбором размерности, диапазона массива и отрезка для поиска******************
Console.Write("Программа задает массив из случайных чисел и находит количество элементов массива, значения которых лежат в отрезке [х,у]");
Console.WriteLine("");

Console.Write("Введите желаемую размерность массива ");
int arrLen = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите диапазон чисел для заполнения массива через пробел ");
string[]? dipArr= Console.ReadLine().Split(' ');
int arrL = int.Parse(dipArr[0]);
int arrR = int.Parse(dipArr[1]);

int[] array = FillArrayWithRandomNumbers(arrLen, arrL, arrR);

Console.Write("Введите диапазон отрезка для поиска чисел через пробел ");
string[]? dipSegment= Console.ReadLine().Split(' ');
int arrX = int.Parse(dipSegment[0]);
int arrY = int.Parse(dipSegment[1]);

int count = ArraySearch(array, arrX, arrY);

Console.WriteLine("В массиве " + '[' + string.Join(", ", array) + ']' + " количество элементов массива, значения которых лежат в отрезке [" + arrX + "," + arrY + "] = " + count); */