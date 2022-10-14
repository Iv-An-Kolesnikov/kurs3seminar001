//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a=25, b=5 => да
// a=2, b=10 => нет 
// a=9, b=-3 => да
// a=-3, b=9 => нет
Console.Clear();
int num1;
int num2;
int result;
Console.WriteLine("Введите первое число");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
num2 = Convert.ToInt32(Console.ReadLine());
result = 0;
result = num2 * num2;
if (result == num1) Console.WriteLine("Число является квадратом");
else
Console.WriteLine("Число не является квадратом");