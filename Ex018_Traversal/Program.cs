string emp = string.Empty;

// equation: ((4 - 2) * (1 + 3)) / 10
// a[i] parent <--  --> children a[2i], a[2i+1]; example: [1] -> [2], [3]
//                 0    1    2     3    4    5    6    7    8    9    10   11
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };

//                                  / [1]
//                  * [2]                          10 [3]
//        - [4]             + [5]
//   4 [8]  2 [9]      1 [10]  3 [11]

InOrderTraversal(tree);

// Methods:

static void InOrderTraversal(string[] tree, int pos = 1)
{
	if (pos < tree.Length)
	{
		int left = 2 * pos;
		int right = left + 1;

		if (left < tree.Length && !string.IsNullOrEmpty(tree[left])) InOrderTraversal(tree, left);

		Console.WriteLine(tree[pos]);

		if (right < tree.Length && !string.IsNullOrEmpty(tree[right])) InOrderTraversal(tree, right);
	}
}
