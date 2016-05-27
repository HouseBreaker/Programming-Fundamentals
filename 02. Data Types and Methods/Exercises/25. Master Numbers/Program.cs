namespace _25.Master_Numbers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static class Program
	{
		public static void Main(string[] args)
		{
			var num = int.Parse(Console.ReadLine());

			var masterNumbers = Enumerable.Range(1, num).Where(IsMasterNumber);
			Console.WriteLine(string.Join(Environment.NewLine, masterNumbers));
		}

		private static bool IsMasterNumber(int num)
		{
			return ContainsEvenDigit(num) && SumOfDigits(num) && IsPalindrome(num);
		}

		private static bool ContainsEvenDigit(int num)
		{
			return num.ToString().Any(ch => int.Parse(ch.ToString()) % 2 == 0);
		}

		private static bool SumOfDigits(int num)
		{
			return num.ToString().Select(a => int.Parse(a.ToString())).Sum() % 7 == 0;
		}

		private static bool IsPalindrome(int num)
		{
			var str = num.ToString();

			var isPalindrome = str.SequenceEqual(str.Reverse());
			return isPalindrome;
		}
	}
}