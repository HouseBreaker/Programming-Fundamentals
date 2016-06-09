namespace _09.Capitalization
{
	using System;
	using System.Linq;
	using System.Text.RegularExpressions;

	public static class Capitalization
	{
		public static void Main(string[] args)
		{
			var sentence = Console.ReadLine();

			var capitalizedWords =
				Regex.Matches(sentence, @"[^ .,?!;]+").Cast<Match>().Select(a => a.Value).Select(CapitalizeFirstLetter).ToArray();
			var separators = Regex.Matches(sentence, @"[ .,?!;]+").Cast<Match>().Select(a => a.Value).ToArray();

			var maxLength = Math.Max(capitalizedWords.Length, separators.Length);

			for (var i = 0; i < maxLength; i++)
			{
				var firstItem = i < capitalizedWords.Length ? capitalizedWords[i] : string.Empty;
				var secondItem = i < separators.Length ? separators[i] : string.Empty;

				Console.Write(firstItem + secondItem);
			}

			Console.WriteLine();
		}

		private static string CapitalizeFirstLetter(string input)
		{
			var capitalized = char.ToUpper(input[0]) + input.Substring(1, input.Length - 1);
			return capitalized;
		}
	}
}