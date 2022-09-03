// Перебор слов.
// Составить все возможные n-буквенные слова для заданного алфавита.

char[] s = { 'а', 'и', 'с', 'в' };

// всевозможные слова из 1 буквы

int count = s.Length;
int n = 1;

for (int i = 0; i < count; ++i)
{
	Console.WriteLine($"{n++,-5}{s[i]}");
}

// всевозможные трёхбуквенные слова

n = 1;

for (int i = 0; i < count; ++i)
	for (int j = 0; j < count; ++j)
		for (int k = 0; k < count; ++k)
		{
			Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}");
		}

// общее решение
// универсальный метод для многобуквенных слов

Console.WriteLine(new string('=', 40));

PrintAllPossibleWords(s, 3);

static void PrintAllPossibleWords(char[] alphabet, int lettersInWord)
{
	int[] word = new int[lettersInWord];
	int letterMaxIndex = alphabet.Length - 1;
	int n = 1;
	do
	{
		Console.Write((n++).ToString().PadRight(5));
		PrintWord(word, alphabet);
	} while (RolloverLetter(word, letterMaxIndex));
}

static bool RolloverLetter(int[] word, int letterMaxIndex)
{
	int wordLastIndex = word.Length - 1;
	for (int i = 0; i <= wordLastIndex; ++i)
	{
		if (word[i] < letterMaxIndex)
		{
			word[i]++;
			return true;
		}

		// word[i] is last letter of the alphabet
		if (i < wordLastIndex)
		{
			word[i] = 0;
			continue;
		}
	}

	return false;
}

static void PrintWord(int[] word, char[] alphabet)
{
	Console.WriteLine(string.Join(null, word.Select(letterIndex => alphabet[letterIndex]).Reverse()));
}

// общее решение
// способ через рекурсию

Console.WriteLine(new string('=', 20));

int num = 1;
CombineWords("аисв", new char[3]);

void CombineWords(string alphabet, char[] word, int letterIndex = 0)
{
	if (letterIndex == word.Length)
	{
		Console.WriteLine($"{num++,-5}{new string(word)}");
		return;
	}
	for (int i = 0; i < alphabet.Length; ++i)
	{
		word[letterIndex] = alphabet[i];
		CombineWords(alphabet, word, letterIndex + 1);
	}
}
