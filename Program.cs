// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
         array[i] = new Random().Next(100, 1000);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int QuantytiPositiv(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size);
ShowArray(myArray);
Console.WriteLine("Quantyti of positive elements is: " + QuantytiPositiv(myArray));
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumOfElements(int[] array)
{
    int sum = 0;

    for(int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

Console.WriteLine("Sum of elements in odd positions " + SumOfElements(myArray));
*/

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreatArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("Input a element: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double DifferenceElements(double[] array)
{
    double min = array[0];
    double max = array[0];
    double dif = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
        if(array[i] < min)
            min = array[i];
        dif = max - min;
    }
    return dif;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreatArray(size);
ShowArray(myArray);

Console.WriteLine("The difference of the elements is " + DifferenceElements(myArray));
*/