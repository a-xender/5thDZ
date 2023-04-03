
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
