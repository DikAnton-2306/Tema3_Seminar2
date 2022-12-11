// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
Console.Clear();
int randomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число    {randomNumber}");

int secondDigit = randomNumber % 10; //Остаток деления на 10
int firstDigit = randomNumber / 100;
// Ниже приведены различные способы вывода на экран результата.
Console.WriteLine(firstDigit * 10 + secondDigit);
Console.WriteLine($"Случайное число без второй цифры -    {firstDigit}{secondDigit}");
Console.WriteLine("Случайное число без второй цифры -    " +firstDigit+secondDigit);
Console.WriteLine($"Случайное число {randomNumber} без второй цифры -    {firstDigit}{secondDigit}");