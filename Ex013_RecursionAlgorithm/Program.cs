Console.Clear();

// two-dimensional array - [rows, cols]:

string[,] table = new string[2, 5];

table[1, 2] = "слово";

for (int row = 0; row < 2; ++row)
{
	for (int col = 0; col < 5; ++col)
	{
		Console.Write($"-{table[row, col]}-");
	}
	Console.WriteLine();
}

// matrix methods:

static void FillMatrix(int[,] matrix)
{
	Random rnd = new Random();
	for (int i = 0; i < matrix.GetLength(0); ++i)
	{
		for (int j = 0; j < matrix.GetLength(1); ++j)
		{
			matrix[i, j] = rnd.Next(1, 10);
		}
	}
}

static void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); ++i)
	{
		for (int j = 0; j < matrix.GetLength(1); ++j)
		{
			Console.Write($"{matrix[i, j]} ");
		}
		Console.WriteLine();
	}
}

int[,] mtx = new int[3, 4];

FillMatrix(mtx);
PrintMatrix(mtx);

// image:

int[,] pic = new int[,]
{
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

static void PrintImage(int[,] matrix)
{
	var bkpForeColor = Console.ForegroundColor;
	for (int i = 0; i < matrix.GetLength(0); ++i)
	{
		for (int j = 0; j < matrix.GetLength(1); ++j)
		{
			int pointValue = matrix[i, j];
			if (pointValue == 0)
			{
				Console.Write("  ");
			}
			else
			{
				if (pointValue == 1)
					Console.ForegroundColor = ConsoleColor.DarkGreen;
				else
					Console.ForegroundColor = ConsoleColor.Yellow;

				Console.Write("\u2588\u2588");
			}
		}
		Console.WriteLine();
	}

	Console.ForegroundColor = bkpForeColor;
}

static void FillImage(int[,] matrix, int fromValue, int toValue, int row, int col)
{
	// rows <-> y
	// cols <-> x
	if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
		return;

	if (matrix[row, col] == fromValue)
	{
		matrix[row, col] = toValue;
		FillImage(matrix, fromValue, toValue, row - 1, col);
		FillImage(matrix, fromValue, toValue, row, col - 1);
		FillImage(matrix, fromValue, toValue, row + 1, col);
		FillImage(matrix, fromValue, toValue, row, col + 1);
	}
}

PrintImage(pic);

FillImage(pic, 0, 2, 5, 5);
PrintImage(pic);

FillImage(pic, 2, 0, 5, 5);
FillImage(pic, 0, 2, 13, 13);
PrintImage(pic);

// recursion:

// factorial

static long Factorial(long n)
{
	// 1! = 1
	// 0! = 1

	if (n <= 1)
		return 1;

	return n * Factorial(n - 1);
}

static double FactorialDbl(double n)
{
	// 1! = 1
	// 0! = 1

	if (n <= 1)
		return 1;

	return n * FactorialDbl(n - 1);
}

for (int i = 0; i <= 21; ++i)
{
	Console.WriteLine($"{i}! =\t{Factorial(i),20}\t{FactorialDbl(i)}");
}

// fibonacci

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

static int Fibonacci(int n)
{
	if (n == 1 || n == 2)
		return 1;

	return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i <= 42; ++i)
{
	Console.WriteLine($"{i}\t{Fibonacci(i)}");
}
