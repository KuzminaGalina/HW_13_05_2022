// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число  ");

int number = Convert.ToInt32(Console.ReadLine());
int number1 = number / 10;
int number2 = number1 % 10;

Console.WriteLine(number2);
