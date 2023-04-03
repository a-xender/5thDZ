
//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Console.WriteLine("Введите длину массива");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[a];
// FillArray(array);
// PrintArray(array);
// EvenSum(array);


// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000);
// }
// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }
// void EvenSum(int[] array)
// {

//     int sum = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             sum++;
//     }
//     Console.WriteLine($"Количество четных чисел в массиве {sum}");

// }




// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Console.WriteLine("Введите длину массива");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[a];
// FillArray(array);
// PrintArray(array);
// OddSum(array);


// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 101);
// }
// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }
// void OddSum(int[] array)
// {

//     int sum = 0;

//     for (int i = 1; i < array.Length; i=i+2)
//     sum=sum+array[i];
//     Console.WriteLine($"Сумма нечетных элементов в массиве {sum}");

// }

//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Console.WriteLine("Введите длину массива");
// int a = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[a];
// FillArray(array);
// PrintArray(array);
// MinMaxGap(array);

// void FillArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-10, 11);
// }
// void PrintArray(double[] array)
// {
//     foreach (double item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }
// void MinMaxGap(double[] array)
// {
//     double min = array[0];
//     double max = array[0];

//     for (int i = 1; i < array.Length; i++)
//     {
//         {
//             if (array[i] > max)
//                 max = array[i];
//         }
//         {
//             if (array[i] < min)
//                 min = array[i];
//         }
//     }
//     double gap = max - min;
//     Console.WriteLine($"Разница между макс и мин значением массива равна {gap}");
// }



// + 6-я домашка
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.WriteLine("Введите количество чисел");
// int i = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[i];
// SumPositive(array);
// void SumPositive(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"Введите {i+1}-ое число");
//     int value = Convert.ToInt32(Console.ReadLine());
//     array[i] = value;
//     if (array[i] > 0)
//         sum++;
//     }
//     Console.WriteLine($"Среди введенных чисел {sum} числа больше нуля");
// }

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// y1-k1*x-b1=0; y=k1*x+b1
// k1*x=y1-b1;
// x=(y1-b1)/k1;
// y2-k2*x-b2=0; y=k2*x+b2

// Console.WriteLine("Введите значение b1");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение k1");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение b2");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение k2");
// double k2 = Convert.ToDouble(Console.ReadLine());
// CrossingDot(b1, k1, b2, k2);

// void CrossingDot(double b1, double k1, double b2, double k2)
// {
//     if (k1 == k2 && b1 == b2)
//         Console.WriteLine("Прямые лежат друг на друге");
//     else if (k1 == k2 && b1 != b2)
//         Console.WriteLine("Прямые параллельные");
//     else if (k1 != k2 && b1 == b2)
//     {
//         double x = 0;
//     double y = k1 * x + b1;
//     Console.WriteLine($"Точка пересечения находится в координатах ({x}, {y})");
//     }
//     else
//     {
//         double x = (b2 - b1) / (k1 - k2);
//         double y = k1 * x + b1;
//         Console.WriteLine($"Точка пересечения находится в координатах ({x},  {y})");
//     }

// }

// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.

// *Пример:*

// - для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]


// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n+n-1];
// FillArray(array);
// PrintArray(array);



// void FillArray(int[] array)
// {
//     array[n-1] = 0;
//     array[n] = 1;
//     array[n - 2] = 1;
//     for (int i = n - 2; i >= 0; i--)
//         array[i] = array[i+2] - array[i+1];
//     for (int i = n+1 ; i <(n+n-1); i++)
//         array[i] = array[i-2] + array[i-1];

// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }