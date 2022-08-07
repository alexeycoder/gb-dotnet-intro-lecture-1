void FillArray(int[] collection)
{
	int length = collection.Length;
	int index = 0;
	while (index < length)
	{
		collection[index] = new Random().Next(1, 10);
		++index;
	}
}

void PrintArray(int[] collection)
{
	int lastIndex = collection.Length - 1;
	int i = 0;
	while (i < lastIndex)
	{
		Console.Write($"{collection[i]}, ");
		++i;
	}
	Console.WriteLine(collection[lastIndex]);
}

int IndexOf(int[] collection, int find)
{
	for (int i = 0; i < collection.Length; ++i)
	{
		if (collection[i] == find)
			return i;
	}

	return -1;
}

int[] array = new int[10];

for (int i = 0; i < 10; ++i)
{
	FillArray(array);
	PrintArray(array);
	Console.WriteLine($"Index of '4' = {IndexOf(array, 4)}");
	Console.WriteLine("-----------------------------");
}
