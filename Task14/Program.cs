// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23. 161
// 14 -> нет
// 46 -> нет
// 161 -> да

// 14 ---------------------------
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Multiplycity(number)) Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно");

bool Multiplycity(int num)
{
	return num % 7 == 0 && num % 23 == 0;
}
