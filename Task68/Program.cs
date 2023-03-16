// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

int Accerman(int num1, int num2)
{
	while (num1 != 0)
	{
		if (num2 == 0) num2 = 1;
		else num2 = Accerman(num1, num2 - 1);
		num1 = num1 - 1;
	}
	return num2 + 1;
}

// Program body--------------------------------------------
int number1 = Promt("Введите первое число : ");
int number2 = Promt("Введите второе число : ");
int accerman = Accerman(number1, number2);
Console.WriteLine($"m = {number1}, n = {number2} -> A(m,n) = {accerman}");