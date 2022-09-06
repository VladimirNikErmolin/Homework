// Какое число больше?

Console.WriteLine("Введите первое число");
string inputFirstNumber = Console.ReadLine();

Console.WriteLine("Введите второе число");
string inputSecondNumber = Console.ReadLine();

int FirstNumber = int.Parse(inputFirstNumber);
int SecondNumber = int.Parse(inputSecondNumber);

if (FirstNumber == SecondNumber)
{
    Console.WriteLine($"Первое число {FirstNumber} равно второму числу {SecondNumber}");
}
if (FirstNumber > SecondNumber)
{
    Console.WriteLine($"Первое число {FirstNumber} больше второго числа {SecondNumber}");
}
if (FirstNumber < SecondNumber)
    Console.WriteLine($"Второе число {SecondNumber} больше первого числа {FirstNumber}");