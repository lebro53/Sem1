// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
int Conversion(int num)
{
	double conversion = 0;
	double count = 0.1;
	for (int i = 0; num != 0; i++)
	{
		conversion = conversion / 10 + num % 2;
		num = num / 2;
		count *= 10;
	}
	int result = Convert.ToInt32(conversion * count);
	return result;
}
// int Conversion(int num)
// {
// 	int conversion = 0;
// 	int count = 1;
// 	for (int i = 0; num != 0; i++)
// 	{
// 		conversion = conversion + num % 2 * count;  
// 		num = num / 2;                                 
// 		count *= 10;
// 	}
// 	return conversion;
// }

// Reogram body--------------------------------------------
int number = Promt("Введите десятичное число для его преобразования в двоичное");
Console.WriteLine($"Число {number} в двоичной системе = {Conversion(number)}");

