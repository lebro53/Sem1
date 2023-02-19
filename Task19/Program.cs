// Methods-----------------------------------------
// int Promt(string massege)
// {
// 	Console.Write(massege);
// 	string value = Console.ReadLine();
// 	int result = Convert.ToInt32(value);
// 	return result;
// }
// bool ConditionCheck(int num)
// {
// 	if (num > 9999 && num < 100000) return true;
// 	else return false;
// }
// bool Palindrome(int num)
// {
// 	int newNumber = 0;
// 	int num5 = num % 10;
// 	int num4 = num / 10 % 10;
// 	int num3 = num / 100 % 10;
// 	int num2 = num / 1000 % 10;
// 	int num1 = num / 10000;
// 	newNumber = num5 * 10000 + num4 * 1000 + num3 * 100 + num2 * 10 + num1;
// 	if (num1 == num5 && num2 == num4)
// 	{
// 		Console.WriteLine($"Да, число {newNumber} является палиндромом");
// 		return true;
// 	}
// 	else
// 	{
// 		Console.WriteLine($"Нет, число {num} не является палиндромом числа");
// 		return false;
// 	}
// }

// Program body ----------------------------------
// int number = Promt("Введите число: ");      // 12345

// if (ConditionCheck(number))
// {
// 	Palindrome(number);
// }
// else Console.WriteLine("Число должно быть пятизначным!");

// -------------------- Universal version
// Methods------------------------------------
int Promt(string massege)
{
	Console.Write(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
bool Turning(int num)
{
	int controlNumber = num;
	int numA = 0;
	while (num > 0)
	{
		numA = numA * 10 + num % 10;
		num = num / 10;
	}
	if (numA == controlNumber) return true;
	else return false;
}

// Program body-------------------------------

int number = Promt("Введите число: ");
if (Turning(number)) Console.Write($"Число {number} является полиндромом");
else Console.Write($"Число {number} не является полиндромом");

