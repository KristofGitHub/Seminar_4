// 1. Написать программу, которая принимает на вход число и выдает количество цифр в числе.
// int dec = 10, result = 0;
// Console.WriteLine("Введите любое целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// while (number/dec > 0) 
// {
//     number = number/10;
//     result++;
// }
// result++;
// Console.WriteLine($"В введённом вами числе {result} цифр(а/ы)");
// *******************************************************************************************************************************

// 2. Написать программу, которая бы выводила на экран массив из N элементов, заполненных целочисленными значениями от 0 до дохуя.

// Console.WriteLine("Введите размер массива: ");
// int array_size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение в ячейке: ");
// int min_value = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение в ячейке: ");
// int max_value = Convert.ToInt32(Console.ReadLine());

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int index = 0; index < size; index++){newArray[index] = new Random().Next(minValue, maxValue + 1);}
//     return newArray;
// }

// void PrintArray(int[] arrayExample)
// {
//     int size = arrayExample.Length;
//     for(int index = 0; index < size; index++){Console.Write(arrayExample[index] + " ");}
//     Console.WriteLine();
// }

// int[] userArray = CreateRandomArray(array_size, min_value, max_value);
// PrintArray(userArray);
// *******************************************************************************************************************************

// 3. Напишите программу, которая принимает число N и выдает произведение чисел от 1 до N.

int result = 1;
Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Произведение чисел ");
for(int i = 1; i <= num; i++)
{
    result = i * result;
    if (i == num) Console.Write($"{i}");
    else Console.Write($"{i}*");
}
Console.WriteLine($" равно {result}");
