// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 100 && number < 1000) Console.WriteLine($"Второе цифра введенного числа = {SecondNumber(number)}");
else Console.WriteLine("Error. Введенно не трехзначное число");

int SecondNumber(int num)
{
	return (num / 10) % 10;
}

// ----------------------------------------------------------------------------------------
// int Promt(string message)
// {
// 	Console.Write(message);
// 	string value = Console.ReadLine();
// 	int result = Convert.ToInt32(value);
// 	return result;
// }

// int number = Promt("Введите число: ");
// if (number < 100 || number >= 1000)
// {
// 	Console.WriteLine("Вы ввели не трехзначное число пожалуйста повторите ввод: ");
// 	return;                                КАКОЙ СМЫСЛ? 
// }
// Console.WriteLine("Введенное число : " + number);
// int secondRank = number / 10 % 10;
// Console.WriteLine("Второе число : " + secondRank);