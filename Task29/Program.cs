// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// Methods-----------------------------------------
int Promt(string massege)
{
	Console.Write(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
int[] NewArray(int num, int min, int max)
{
	int[] array = new int[num];
	Random rnd = new Random();
	int i = 0;
	for (i = 0; i < array.Length; i++)
	{
		array[i] = rnd.Next(min, max + 1);
	}
	return array;
}
void PrintArray(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write($"{arr[i]}");
		if (i < arr.Length - 1) Console.Write(", ");
	}
	Console.Write(" -> [");
	for (int i = 0; i < arr.Length; i++)        // Это похоже на извращение
	{
		Console.Write($"{arr[i]}");
		if (i < arr.Length - 1) Console.Write(", ");
	}
	Console.WriteLine("]");
}


// Program body------------------------------------
int number = Promt("Введите длину массива: ");
int minimum = Promt("Введите минимальное число массива: ");
int maximum = Promt("Введите максимальное число массива: ");
PrintArray(NewArray(number, minimum, maximum));
// Console.WriteLine($"{PrintArray(NewArray(number, minimum, maximum))}"); Нельзя, т.к. void