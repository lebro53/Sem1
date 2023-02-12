Console.Write("Введите число для расчета его квадрата: ");
double number = Convert.ToDouble(Console.ReadLine()); // Сделал вместо int через функцию double, т.к. расширяет наши способности
double sqr = number * number;
Console.WriteLine($"Квадрат числа {number} = {sqr}");