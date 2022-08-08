// Задача 38. Задайте с клавиатуры массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры

//************************
void InputArray(double[] arr)
{
    Console.WriteLine($"Введите числа для массива из {arr.Length}-ми элементов");

    for (int i = 0; i < arr.Length;)
    {
        Console.Write($"{i + 1}й элемент массива ");
        if (double.TryParse(Console.ReadLine(), out double itemp))
        {
            arr[i] = Convert.ToDouble(itemp);
            i++;
        }
        else
        {
            Console.Write("Элемент должен быть числовой! Введите еще раз ");
        }
    }
}

//************************
double ArraySearch(double[] arr, string mm)
{
    double maxMin = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (maxMin < arr[i] && mm == "max")
        {
            maxMin = arr[i];
        }
        else if (maxMin > arr[i] && mm == "min")
        {
            maxMin = arr[i];
        }
    }
    return maxMin;
}

//***********************
Console.Write("Программа задает с клавиатуры массив вещественных (double) чисел и находит разницу между максимальным и минимальным элементов массива.");
Console.WriteLine("");

Console.Write("Введите желаемую размерность массива ");
int arrLen = Convert.ToInt32(Console.ReadLine());

double[] array = new double[arrLen];
InputArray(array);

double difference = ArraySearch(array, "max") - ArraySearch(array, "min");

Console.WriteLine("В массиве " + '[' + string.Join(", ", array) + ']' + " разница между максимальным и минимальным элементами массива = " + difference);
