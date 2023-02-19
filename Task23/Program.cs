// Methods-----------------------------------------
int Promt(string massege)
{
	Console.Write(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
void Square(int num)
{
	for (int i = 1; i <= num; i++)
	{
		Console.WriteLine($"{i,5} = {i * i * i,5}");
	}
}

// Program body --------------------------------
int number = Promt("Введите натуральное число: ");
if (number > 0) Square(number);
else Console.WriteLine("Ошибка. Введено не натуральное число");