namespace _10.Palindrome_Index
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static class PalindromeIndex
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var palindromeIndex = -1;
			if (!IsPalindrome(input))
			{
				for (int i = 0; i < input.Length; i++)
				{
					var removedSubString = input.Remove(i, 1);
					if (IsPalindrome(removedSubString))
					{
						palindromeIndex = i;
						break;
					}
				}
			}

			Console.WriteLine(palindromeIndex);
		}

		private static bool IsPalindrome(string input)
		{
			return input == new string(input.Reverse().ToArray());
		}
	}
}