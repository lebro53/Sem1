// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;

}
int[] CreateArray(int num)
{
	int[] array = new int[num];
	for (int i = 0; i < array.Length; i++)
	{
		Console.WriteLine($"Введите {i} число массива: ");
		array[i] = Convert.ToInt32(Console.ReadLine());
	}
	return array;
}
int SumPositiveNumbers(int[] array)
{
	int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > 0) sum += 1;
	}
	return sum;
}

void PrintArray(int[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write($"{array[i]}, ");
		else Console.WriteLine($"{array[i]}]");
	}
}

// Program body--------------------------------------------
int size = Promt("Введите размер массива: ");
if (size >= 0)
{
	int[] arr = CreateArray(size);
	Console.Clear();
	PrintArray(arr);
	Console.WriteLine($"Количество положительных чисел больше 0 введенных пользователем = {SumPositiveNumbers(arr)}");
}
else Console.WriteLine("Размер массива должен быть положительным");