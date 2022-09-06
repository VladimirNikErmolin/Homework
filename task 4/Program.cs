// Нахождение чётных чисел натурального ряда

Console.WriteLine("Введите натуральное число N");
string numberN = Console.ReadLine();

int n = int.Parse(numberN);

for (int i = 2; i <= n; i = i + 2)
Console.WriteLine(i);