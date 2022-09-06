// Нахождение максимального числа из трех чисел
Console.WriteLine("Введите первое число");
string inputFirstNumber = Console.ReadLine();

Console.WriteLine("Введите второе число");
string inputSecondNumber = Console.ReadLine();

Console.WriteLine("Введите третье число");
string inputThirdNumber = Console.ReadLine();

int FirstNumber = int.Parse(inputFirstNumber);
int SecondNumber = int.Parse(inputSecondNumber);
int ThirdNumber = int.Parse(inputThirdNumber);


if (FirstNumber > SecondNumber)
{
    if ( FirstNumber > ThirdNumber)
    {
        Console.WriteLine($"Максимально первое число {FirstNumber} ");
    }
   else
    {
        Console.WriteLine($"Максимально третье число {ThirdNumber} ");
    }
}
else
{
    if ( SecondNumber > ThirdNumber)
    {
        Console.WriteLine($"Максимально второе число {SecondNumber}");
    }
    else
    {
        Console.WriteLine($"Максимально третье число {ThirdNumber}");
    }
}
