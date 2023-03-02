// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;

}
int[] CreateArray(int num, int min, int max)
{
	int[] array = new int[num];
	Random rnd = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = rnd.Next(min, max + 1);
	}
	return array;
}
void PrintArray(int[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write($"{array[i]}, ");
		else Console.Write($"{array[i]}]");
	}
}
int[] SwapElemArray(int[] array)          //Сделал через тип данных int для более красивого выводы на экран (как в примере)
{                                         //Тип void нельзя преобразовать в int, следовательно конструкция как в примере не получится.
	for (int i = 0; i < array.Length; i++)
	{
		array[i] *= -1;
	}
	return array;
}

// Program body--------------------------------------------
int size = Promt("Введите размер массива: ");
int minNumberArray = Promt("Введите начало массива: ");
int maxNumberArray = Promt("Введите конец массива: ");
int[] arr = CreateArray(size, minNumberArray, maxNumberArray);
Console.Clear();
PrintArray(arr);
Console.Write(" -> ");
int[] swapElemArray = SwapElemArray(arr);
PrintArray(swapElemArray);