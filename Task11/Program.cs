// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число из отрезка 100 - 999 : {number}");
// int firstDigit = number / 100;
// Console.WriteLine($"Первое число {firstDigit}");
// int secondDigit = number % 10;
// Console.WriteLine($"Второе число {secondDigit}");
// int thirdDigit = (firstDigit * 10) + secondDigit;
// Console.WriteLine($"Получивщееся двухзначное число => {thirdDigit}");

int number = new Random().Next(100, 1000);
Console.WriteLine($"Число в диапазоне 100-999: {number}");

int newNumber = NewNumber(number);
Console.WriteLine($"Новое число, полученное из первой и последней цифры случайного числа - {newNumber}");

int NewNumber(int num)
{
	int firstDigit = num / 100;
	int secondDigit = num % 10;
	int result = firstDigit * 10 + secondDigit;

	return result;
}