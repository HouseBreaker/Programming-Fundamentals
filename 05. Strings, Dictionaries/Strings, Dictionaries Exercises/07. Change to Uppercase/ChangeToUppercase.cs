namespace _07.Change_to_Uppercase
{
	using System;
	using System.Text.RegularExpressions;

	public static class ChangeToUppercase
	{
		public static void Main(string[] args)
		{
			var sentence = Console.ReadLine();
			const string UpcaseRegex = @"<upcase>(.+?)<\/upcase>";

			var result = sentence;
			foreach (Match uppercaseWord in Regex.Matches(sentence, UpcaseRegex))
			{
				var wordWithTag = uppercaseWord.Groups[0].Value;
				var word = uppercaseWord.Groups[1].Value;
				result = result.Replace(wordWithTag, word.ToUpper());
			}

			Console.WriteLine(result);
		}
	}
}
