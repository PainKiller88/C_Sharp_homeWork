// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Это программа, которая на вход принимает два числа и выдаёт, какое число большее из двух.");
Console.Write("введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 < number2){
    Console.WriteLine($"Максимальное число из двух {number2}");
}
if (number1 > number2)
{
    Console.WriteLine($"Максимальное число из двух {number1} ");
} 
else {
    Console.WriteLine("Вы ввели неверные данные");
}
