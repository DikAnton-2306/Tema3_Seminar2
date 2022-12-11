// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Clear();
Console.WriteLine("Введите первое число");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите торое число");
int secondNumber = int.Parse(Console.ReadLine());

int ostatok = firstNumber % secondNumber; //% - это ОСТАТОК после деления первого на второе

if (ostatok == 0)
    Console.WriteLine($"{firstNumber} кратно {secondNumber}");
else
    Console.WriteLine($"{firstNumber} не кратно {secondNumber}, остаток {ostatok}");