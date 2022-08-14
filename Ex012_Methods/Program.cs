// Вид 1: no args, no return

void Method1()
{
	Console.WriteLine("Приветики!");
}

Method1();

// Вид 2: args, but no return

void Method2(string msg)
{
	Console.WriteLine(msg);
}

Method2("Просто гениальный метод.");

void Method21(string msg, int count)
{
	while (count > 0)
	{
		Console.WriteLine(msg);
		--count;
	}
}

Method21(count: 4, msg: "Вызов метода с именованными параметрами.");

// Вид 3: no args, but return

int Method3()
{
	return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine($"Year {year}");

// Вид 4: args and return

string Method4(int count, string text)
{
	string result = string.Empty;
	for (int i = 0; i < count; ++i)
	{
		result += text;
	}

	return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);

// Цикл for:

for (int i = 2; i <= 9; ++i)
{
	for (int j = 2; j <= 9; ++j)
	{
		Console.WriteLine($"{i} x {j} = {i * j}");
	}
	Console.WriteLine();
}

// Задача:

string str = "Дан текст. В тексте нужно все пробелы заменить чёрточками,\n"
			+ "маленькие буквы “к” заменить большими “К”,\n"
			+ "а большие “С” маленькими “с”.\n"
			+ "Ясна ли задача?";

string Replace(string text, char oldValue, char newValue)
{
	string result = string.Empty;

	int length = text.Length;
	for (int i = 0; i < length; ++i)
	{
		if (text[i] == oldValue)
			result += newValue;
		else
			result += text[i];
	}

	return result;
}

string transformedStr = Replace(str, ' ', '|');
transformedStr = Replace(transformedStr, 'к', 'К');
transformedStr = Replace(transformedStr, 'С', 'с');

Console.WriteLine(transformedStr);

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
	int count = array.Length;

	for (int i = 0; i < count; ++i)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

void SelectionSort(int[] array)
{
	for (int i = 0; i < array.Length - 1; ++i)
	{
		int minPosition = i;

		for (int j = i + 1; j < array.Length; ++j)
		{
			if (array[j] < array[minPosition])
				minPosition = j;
		}

		if (minPosition != i)
		{
			Swap(array, i, minPosition);
		}
	}
}

void Swap(int[] array, int indexA, int indexB)
{
	int temp = array[indexA];
	array[indexA] = array[indexB];
	array[indexB] = temp;
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);