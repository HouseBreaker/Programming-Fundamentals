namespace _08.Palindromes
{
	using System;
	using System.Linq;
	using System.Text.RegularExpressions;

	// 80/100 ??????
	public static class Palindromes
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var palindromes = Regex.Matches(input, @"\b\w+\b").Cast<Match>().Select(a => a.Value).Where(IsPalindrome).OrderBy(a => a).ToArray();

			Console.WriteLine(string.Join(", ", palindromes));
		}

		private static bool IsPalindrome(string input)
		{
			return input == new string(input.Reverse().ToArray());
		}
	}
}