int size = 128;
int[,] triangle = new int[size, size];
const int cellWidth = 1;

Console.Clear();
FillTriangle();
//PrintTriangle();
Magic();

// Methods

void FillTriangle()
{
	for (int rowIndex = 0; rowIndex < size; ++rowIndex)
	{
		triangle[rowIndex, 0] = 1;
		triangle[rowIndex, rowIndex] = 1;
	}

	for (int rowIndex = 2; rowIndex < size; ++rowIndex)
	{
		for (int colIndex = 1; colIndex <= rowIndex; ++colIndex)
		{
			triangle[rowIndex, colIndex] = triangle[rowIndex - 1, colIndex - 1] + triangle[rowIndex - 1, colIndex];
		}
	}
}

void PrintTriangle()
{
	for (int rowIndex = 0; rowIndex < size; ++rowIndex)
	{
		for (int colIndex = 0; colIndex < size; ++colIndex)
		{
			if (triangle[rowIndex, colIndex] != 0)
				Console.Write($"{triangle[rowIndex, colIndex],cellWidth}");
		}
		Console.WriteLine();
	}
}

void Magic()
{
	int cellPos = cellWidth * size;
	for (int rowIndex = 0; rowIndex < size; ++rowIndex)
	{
		for (int colIndex = 0; colIndex <= rowIndex; ++colIndex)
		{
			Console.SetCursorPosition(cellPos, rowIndex + 1);
			if (triangle[rowIndex, colIndex] % 2 != 0)
				Console.Write("*"); //Console.Write($"{triangle[rowIndex, colIndex],cellWidth}");
			cellPos += cellWidth * 2;
		}

		cellPos = cellWidth * size - cellWidth * (rowIndex + 1);
		Console.WriteLine();
	}
}
