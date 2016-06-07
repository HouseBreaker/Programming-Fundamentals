namespace _02.Matrix_of_Palindromes
{
	using System;
	using System.Linq;

	public static class Matrix
	{
		public static void Main()
		{
			var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
			var r = input[0];
			var c = input[1];

			var alphabet = new char[26];

			for (int i = 0; i < 26; i++)
			{
				alphabet[i] = (char)('a' + i);
			}

			for (int i = 0; i < r; i++)
			{
				for (int j = i; j < c + i; j++)
				{
					Console.Write("{0}{1}{0} ", alphabet[i], alphabet[j]);
				}

				Console.WriteLine();
			}
		}
	}
}