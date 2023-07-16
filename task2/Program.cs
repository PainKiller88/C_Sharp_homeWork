//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Эта программа принимает число и определяет являктся оно четным или нет.");
Console.Write("Введите любое целое число: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0){
    Console.WriteLine($"Введенное число {number} является четным.");
}
else{
    Console.WriteLine($"Введенное число {number} нечетное.");
}