namespace _13.Vowel_or_Digit
{
	using System;
	using System.Linq;

	public static class VowelOrDigit
	{
		public static void Main(string[] args)
		{
			var input = char.Parse(Console.ReadLine());

			var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
			var digits = Enumerable.Range(0, 9).Select(a => char.Parse(a.ToString())).ToArray();

			if (vowels.Contains(input))
			{
				Console.WriteLine("vowel");
			}
			else if (digits.Contains(input))
			{
				Console.WriteLine("digit");
			}
			else
			{
				Console.WriteLine("other");
			}
		}
	}
}
