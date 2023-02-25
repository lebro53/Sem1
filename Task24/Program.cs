// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Methods-----------------------------------------
int Promt(string massege)
{
	Console.Write(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
int SumNumbers(int num)
{
	int sum = 0;
	for (int i = 1; i <= num; i++)
	{
		checked
		{
			sum = sum + i;
		}
	}
	return sum;
}


// Program body ----------------------------------
int number = Promt("Введите целое положительное число число: ");
int sum = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");