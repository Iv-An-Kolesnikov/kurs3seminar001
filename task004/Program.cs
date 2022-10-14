// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
// 456 => 6
// 782 => 2
// 918 => 8
Console.Clear();
int input;
int number = 0;
Console.WriteLine("Введите трехзначное число");
input = Convert.ToInt32(Console.ReadLine());
if ((input > 99) & (input < 1000)) 
{
    number = input % 10;
    Console.Write("Последняя цифра вверденного числа: " + number);
}
else Console.WriteLine("Введенное число не трехзначное, введите трехзначное число");
