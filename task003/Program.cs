// Напишите программу, которая на вход принимает число (N), а на выходе показывает все целые числа в промежутке от -N до N
// 4 => "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 => "-2, -1, 0, 1, 2"
Console.Clear();
int input;
//int output;
//int raschet;
int cycle1 = 0;
int cycle2 = 1;
int predel1;
int predel2;
Console.WriteLine("Введите число");
input = Convert.ToInt32(Console.ReadLine());
predel1 = input * 2;
predel2 = 2;
input = input * (-1);
while (cycle2 < predel2)
{    
    while (cycle1 < predel1)
    {
        Console.Write(input + ", ");
        input = input + 1;
        cycle1++;
    }
    cycle2++;
    Console.Write(input);
}