// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[new Random().Next(5, 15)];
CreateArray(array);
PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве равно {GetCountNumber(array)}");


int GetCountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;   
}

void CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array2 = new int[new Random().Next(5, 10)];
CreateArrayTask2(array2);
PrintArrayTask2(array2);
Console.WriteLine($"Сумма элементов равна {GetSumElem(array2)}");

int GetSumElem(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

void CreateArrayTask2(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
}

void PrintArrayTask2(int[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}

   
//Задача 3.Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array3 = new double [new Random().Next(5, 10)];
CreateArrayTask3(array3);
PrintArrayTask3(array3);
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {GetDifference(array3)}");

double GetDifference(double[] array)
{
    //double result = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
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
    return max - min;
}

void CreateArrayTask3(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()*100;
    }
}

void PrintArrayTask3(double[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
}


