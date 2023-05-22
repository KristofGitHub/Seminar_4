// 1. Написать программу, которая принимает на вход число и выдает количество цифр в числе.
int dec = 10, result = 0;
Console.WriteLine("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number/dec > 0) 
{
    number = number/10;
    result++;
}
result++;
Console.WriteLine($"В введённом вами числе {result} цифр(а/ы)");