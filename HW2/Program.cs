// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
int number2 = 1;
int number3 = 1;
int index = 1;
int result = 1;
Console.WriteLine("Введите число ");

int number = Convert.ToInt32(Console.ReadLine());

int number1 = number / 100;
if (number1 == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    for(int i = 1000; ; i = i * 10)
    {
    number2 = number / i;
    if(number2 == 0)
    {
        number3 = number / index;
        result = number3 % 10;
        Console.WriteLine(result);
        break;
    }
    index = index * 10;
    
    }
}