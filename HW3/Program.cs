// Напишите программу, которая принимает на вход цифру, обозначающиую день недели и проверяет, является ли этот день недели выходным

Console.WriteLine("Введите день недели (цифру от 1 до 7) ");

int number = Convert.ToInt32(Console.ReadLine());

if(number == 6 || number ==7)
{
    Console.WriteLine("Выходной день");
}
else if (number < 1 || number > 7)
{
    Console.WriteLine("Такого дня недели не существует)) ");
}
else
{
    Console.WriteLine("Будний день");
}

