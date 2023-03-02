// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;

}
int[] CreateFibonachiArray(int num, int num1, int num2)
{
	int[] array = new int[num];
	array[0] = num1;
	array[1] = num2;
	for (int i = 2; i < array.Length; i++)
	{
		array[i] = array[i - 1] + array[i - 2];
	}
	return array;
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

// Program body---------------------------------------------
int size = Promt("Введите размер массива: ");
int numberOne = 0;
int numberTwo = 1;
int[] arr = CreateFibonachiArray(size, numberOne, numberTwo);
Console.Clear();
PrintArray(arr);