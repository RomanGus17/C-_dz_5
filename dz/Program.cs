// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//Например: [345, 897, 568, 234] -> 2

// void FillArray(int[] num) //функция, которая создает рандомный массив
// {
//     for(int i = 0; i < num.Length; i++)
//     {
//         num[i] = new Random().Next(100,1000);
//     }
// }

// void PrintArray(int[] num) //функция, которая показывает рандомный массив
// {
//     for(int i = 0; i < num.Length; i++)
//     {
//         Console.Write(num[i] + " ");
//     }
//     Console.Write("");
// }

// int[] num = new int[4];
// int cnt = 0;

// void EvenNumbers(int[] num) //функция, которая вычисляет кол-во четных чисел
// {
//     for (int a = 0; a < num.Length; a++)
//     if (num[a] % 2 == 0)
//     cnt++;
// }

// FillArray(num);
// PrintArray(num);
// EvenNumbers(num);
// Console.Write($"-> {cnt}");



//-------------------------------------------------------------------------------------------------
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//Например:
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

// void FillArray(int[] num) //функция, которая создает рандомный массив
// {
//     for(int i = 0; i < num.Length; i++)
//     {
//         num[i] = new Random().Next(-100,100);
//     }
// }

// void PrintArray(int[] num) //функция, которая показывает рандомный массив
// {
//     for(int i = 0; i < num.Length; i++)
//     {
//         Console.Write(num[i] + " ");
//     }
//     Console.Write("");
// }


// void EvenPozition(int[] num) //функция, которая вычисляет сумму чисел на четных позициях
// {
//     int sum = 0;
//     for (int a = 0; a < num.Length; a+=2)
//     sum = sum + num[a];
//     Console.Write($"{sum}");
// }

// int[] num = new int[4];

// FillArray(num);
// PrintArray(num);
// EvenPozition(num);


//-------------------------------------------------------------------------------------------------
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//Например:
//[3 7 22 2 78] -> 76

void FillArray(int[] num) //функция, которая создает рандомный массив
{
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(1,100);
    }
}

void PrintArray(int[] num) //функция, которая показывает рандомный массив
{
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.WriteLine("");
}

void Difference(int[] num) //функция, которая вычисляет разницу максимального и минимального значений
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int a = 0; a < num.Length; a++)
    {
        if (num[a] > max)
            {
                max = num[a];
            }
        if (num[a] < min)
            {
                min = num[a];
            }
    }
    Console.WriteLine($"MAX = {max}, MIN = {min}. Разница = {max - min}");
}

int[] num = new int[5];
FillArray(num);
PrintArray(num);
Difference(num);